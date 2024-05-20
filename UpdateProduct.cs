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
    public partial class UpdateProduct : Form
    {
        public static DbConnection connection;
        public UpdateProduct()
        {
            connection = new DbConnection();
            InitializeComponent();
        }
        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            txtNamePtoduct.Text = ViewProduct.productname;
            txtprice.Text = ViewProduct.price + "";
            cboCatalog.Text = ViewProduct.catalog;
            cboCatalog.Items.Clear();
            string danhmuc = "select * from DanhMuc";
            SqlDataReader reader = connection.Query(danhmuc);
            while(reader.Read())
            {
                cboCatalog.Items.Add(reader.GetString(1));
            }
            reader.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProduct view = new ViewProduct();
            view.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string nameproduct = txtNamePtoduct.Text;
            string priceproduct = txtprice.Text;
            int Id = ViewProduct.Id;
            string tendanhmuc = cboCatalog.Text;
            string Iddanhmuc = "select ID from DanhMuc where Ten_DM = '" +tendanhmuc+ "'";
            SqlDataReader reader = connection.Query(Iddanhmuc);
            int iddanhmuc = 0;
            if(reader.Read())
            {
                iddanhmuc = reader.GetInt32(0);
            }
            reader.Close();
            string update = "UPDATE SanPham SET TenSP = @tensp, DonGia = @dongia, ID_DanhMuc = @iddanhmuc WHERE ID = @id";
            int results;
            using (SqlCommand cmd = new SqlCommand(update, connection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("tensp", nameproduct);
                cmd.Parameters.AddWithValue("dongia", priceproduct);
                cmd.Parameters.AddWithValue("iddanhmuc", iddanhmuc);
                cmd.Parameters.AddWithValue("id", Id);

                results = cmd.ExecuteNonQuery();
            }

            if(results > 0)
            {
                MessageBox.Show("Cap nhat san pham thanh cong!!!","Successor", MessageBoxButtons.OK);
                return;
            }

            else
            {
                MessageBox.Show("Cap nhat san pham that bai!!!", "Error", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
