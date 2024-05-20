using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class ViewProduct : Form
    {
        public static string productname;
        public static int price;
        public static string catalog;
        public static int Id;
        public static DbConnection connection;
        public ViewProduct()
        {
            connection = new DbConnection();
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            string listsp = "SELECT TenSP, DonGia, Ten_DM, SanPham.ID FROM SanPham INNER Join DanhMuc ON SanPham.ID_DanhMuc = DanhMuc.ID";
            SqlDataReader reader = connection.Query(listsp);

            lvSanpham.Items.Clear();
            int i = 1;
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(i + "");
                productname = reader.GetString(0);
                lv.SubItems.Add(productname);
                price = reader.GetInt32(1);
                lv.SubItems.Add(price + "");
                catalog = reader.GetString(2);
                lv.SubItems.Add(catalog);
                Id = reader.GetInt32(3);

                //tao button
                Button update = new Button();
                update.Text = "Update";
                update.BackColor = System.Drawing.Color.LightBlue;
                update.Click += (sender, e) =>
                {
                    this.Hide();
                    UpdateProduct updatepr = new UpdateProduct();
                    updatepr.Show();

                };
                lv.SubItems.Add("");
                lv.Tag = update;
                lvSanpham.Controls.Add(update);
                //
                Button delete = new Button();
                delete.Text = "Delete";
                delete.BackColor = System.Drawing.Color.LightBlue;
                delete.Click += (sender, e) =>
                {
                    DialogResult result = MessageBox.Show("Ban thuc su muon xoa san pham ' " + productname + " ' ra khoi danh sach?", "Confirm Message", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        lvSanpham.Items.Remove(lv);
                        lvSanpham.Controls.Remove(update);
                        lvSanpham.Controls.Remove(delete);
                        reader.Close();
                        string dele = "DELETE FROM SanPham WHERE ID = " + Id;
                        SqlDataReader read = connection.Query(dele);
                        if (read.HasRows)
                        {
                            this.Hide();
                            ViewProduct view = new ViewProduct();
                            view.Show();
                        }

                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                };
                lv.SubItems.Add("");
                lv.Tag = delete;
                lvSanpham.Controls.Add(delete);

                lvSanpham.Items.Add(lv);
                //
                // Tính toán vị trí của nút "Update" dựa trên vị trí cột thứ 4 của ListView

                int buttonWidth = 80; // Chiều rộng của nút (có thể điều chỉnh tùy ý)
                int buttonHeight = lvSanpham.Items[0].Bounds.Height; // Chiều cao của nút bằng chiều cao của một hàng trong ListView
                int xPosition = 440; // Tính toán vị trí theo chiều ngang
                int xdelete = 520;
                int yPosition = lvSanpham.Items[lvSanpham.Items.Count - 1].Bounds.Bottom - 25; // Lấy vị trí dưới cùng của hàng trong ListView

                // Đặt vị trí và kích thước cho nút "Update"
                update.Bounds = new System.Drawing.Rectangle(xPosition, yPosition, buttonWidth, buttonHeight);
                delete.Bounds = new System.Drawing.Rectangle(xdelete, yPosition, buttonWidth, buttonHeight);
                //
                i++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }
    }
}
