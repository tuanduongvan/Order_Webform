using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class CreateCatalog : Form
    {
        public static DbConnection connection;
        public CreateCatalog()
        {
            connection = new DbConnection();
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage admin = new AdminPage();
            admin.Show();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string namecatalog = txtName.Text;
            if (string.IsNullOrEmpty(namecatalog))
            {
                MessageBox.Show("Namecatalog khong duoc de trong", "Error", MessageBoxButtons.OK);
                return;
            }
            string insert = "INSERT INTO DanhMuc (Ten_DM) VALUES (@namecatalog)";
            int result;
            using (SqlCommand cmd = new SqlCommand(insert, connection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("namecatalog", namecatalog);

                result = cmd.ExecuteNonQuery(); 
            }

            if(result == 1)
            {
                MessageBox.Show("Them moi thanh cong!","Sucessfull",MessageBoxButtons.OK);
                txtName.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Them moi that bai!", "Sucessfull", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
