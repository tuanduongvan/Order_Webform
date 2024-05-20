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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_BanHang
{
    public partial class CreateProduct : Form
    {
        public static DbConnection connection;
        public CreateProduct()
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

        private void create_Click(object sender, EventArgs e)
        {
            string productname = txtPoductname.Text;
            string price = txtprice.Text;
            string tenDM = cbocatalog.Text;
            //string Id_danhmuc = txtIddanhmuc.Text;
            string idDM = "select ID from DanhMuc where Ten_DM = '" + tenDM + "'";
            SqlDataReader rd = connection.Query(idDM);
            string Id_danhmuc = "";
            if (rd.Read())
            {
                Id_danhmuc = rd.GetInt32(0)+"";
            }
            rd.Close();
            if (string.IsNullOrEmpty(productname))
            {
                MessageBox.Show("productname khong duoc de trong", "Error", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("price khong duoc de trong", "Error", MessageBoxButtons.OK);
                return;
            }

            string insert = "INSERT INTO SanPham (TenSP, DonGia, ID_DanhMuc) VALUES (@Ten, @Gia, @ID_DanhMuc)";
            int result;
            using (SqlCommand cmd = new SqlCommand(insert, connection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("Ten", productname);
                cmd.Parameters.AddWithValue("Gia", price);
                cmd.Parameters.AddWithValue("ID_DanhMuc", Id_danhmuc);

                result = cmd.ExecuteNonQuery();
            }

            if (result == 1)
            {
                MessageBox.Show("Tao thanh cong!!!", "Successful", MessageBoxButtons.OK);
                //txtIddanhmuc.Text = "";
                cbocatalog.Text = "";
                txtPoductname.Text = "";
                txtprice.Text = "";
                return;
            }

            else
            {
                MessageBox.Show("Tao that bai!!!", "Error", MessageBoxButtons.OK);
                return;
            }


        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            cbocatalog.DropDownStyle = ComboBoxStyle.DropDownList;
            string catalogload = "select Ten_DM from DanhMuc";
            SqlDataReader reader = connection.Query(catalogload);
            while(reader.Read())
            {
                cbocatalog.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }
    }
}
