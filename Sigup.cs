using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class Sigup : Form
    {
        public static DbConnection connection;
        public Sigup()
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
                for(int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            //string password = txtPassword.Text;
            string password = Hashpassword(txtPassword.Text);
            //string confirmpassword = txtConfirm.Text;
            string confirmpassword = Hashpassword(txtConfirm.Text);
            string phonenumber = txtphone.Text;
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("username not null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("password not null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(confirmpassword))
            {
                MessageBox.Show("confirmpassword not null", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(phonenumber))
            {
                MessageBox.Show("phonenumber not null", "Error", MessageBoxButtons.OK);
                return;
            }

            if(password != confirmpassword)
            {
                MessageBox.Show("password and confirmpassword is not euqal", "Error", MessageBoxButtons.OK);
                return;
            }


            string query = "INSERT INTO [User] (Username, Password, Phonenumber) VALUES (@Username, @Password, @Phonenumber)";
            int result;
            using (SqlCommand command = new SqlCommand(query, connection.GetConnection()))
            {
                // Thêm các tham số
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Phonenumber", phonenumber);

                // Thực thi câu lệnh SQL và nhận kết quả
                result = command.ExecuteNonQuery();
            }

            if (result == 1)
            {
                //lay Iduser tu thong tin vua cap nhat
                string getUsername = "select * from [User] Where Username = '" + username + "' and Password = '" + password +"'";
                SqlDataReader reader = connection.Query(getUsername);
                int test;
                if (reader.Read())
                {
                    int IdUser = reader.GetInt32(0);
                    reader.Close();
                    string role = "Insert into [User_Role] (ID_User, ID_Role) values (@ID_User, @ID_Role)";

                    using (SqlCommand cmd = new SqlCommand(role, connection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@ID_User", IdUser);
                        cmd.Parameters.AddWithValue("@ID_Role", 2);

                        test = cmd.ExecuteNonQuery();
                    }
                }
                reader.Close();

                this.Hide();
                Sigin sigin = new Sigin();
                sigin.Show();
            }
            else
            {
                MessageBox.Show("Sigup that bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sigin sigin = new Sigin();
            sigin.Show();
        }
    }
}
