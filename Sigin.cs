using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace QL_BanHang
{
    public partial class Sigin : Form
    {
        public static DbConnection connection;
        public static int ID;

        public Sigin()
        {
            connection = new DbConnection();
            InitializeComponent();
        }

        public static string Hashpassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string inputpassword = Hashpassword(txtPassword.Text);
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username and password is null ", "Error message", MessageBoxButtons.OK);
            }
            else
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username is null", "Error message", MessageBoxButtons.OK);
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("password is null", "Error message", MessageBoxButtons.OK);
                }

            }

            string getId = "select ID from [User] where Username = '" + username +"'";
            SqlDataReader red = connection.Query(getId);
            if (red.Read())
            {
                ID = red.GetInt32(0);
            }
            red.Close();
            string query = "select * from [User] where Username = '" + username + "' and Password = '" + inputpassword +"'";
            SqlDataReader reader = connection.Query(query);
            if (reader.HasRows)
            {
                reader.Close();
                string getRole = "SELECT ID_Role FROM [User] INNER JOIN USer_Role ON [User].ID = User_Role.ID_User where Username = '" + username +"'";
                SqlDataReader readers = connection.Query(getRole);
                if(readers.Read())
                {
                    int IdRole = readers.GetInt32(0);
                    if(IdRole == 1) 
                    {
                        this.Hide();

                        AdminPage adminpage = new AdminPage();
                        adminpage.Show();
                    }
                    if(IdRole == 2)
                    {
                        this.Hide();

                        UserPage userpage = new UserPage();
                        userpage.Show();
                    }
                }
                readers.Close();
                
            }
            else
            {
                MessageBox.Show("username or password is not correct", "Error message", MessageBoxButtons.OK);
                txtUserName.Text = "";
                txtPassword.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sigup sigup = new Sigup();
            sigup.Show();
        }
    }
}
