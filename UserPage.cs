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
    public partial class UserPage : Form
    {
        public static DbConnection connection;
        public UserPage()
        {
            connection = new DbConnection();
            InitializeComponent();
        }

        public void Reload(List<ListViewItem> list)
        {
            foreach(ListViewItem item in list)
            {
                lvselectedproduct.Items.Add(item);
            }
        }
        private void UserPage_Load(object sender, EventArgs e)
        {
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            string danhmuc = "SELECT * FROM DanhMuc";
            SqlDataReader reader = connection.Query(danhmuc);
            while (reader.Read())
            {
                cboDanhMuc.Items.Add(reader.GetString(1));
            }

            reader.Close();
            string sanpham = "SELECT TenSP, DonGia FROM SanPham";
            SqlDataReader readers = connection.Query(sanpham);
            int i = 1;
            lvProduct.Items.Clear();
            while (readers.Read())
            {
                ListViewItem lv = new ListViewItem(i + "");
                lv.SubItems.Add(readers.GetString(0));
                lv.SubItems.Add(readers.GetInt32(1) + "");
                lvProduct.Items.Add(lv);

                i++;
            }
            readers.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (lvselectedproduct.Items.Count <= 0)
            //{
            //    return;
            //}
            //else
            //{
            //    this.Hide();
            //    List<ListViewItem> list = new List<ListViewItem>();
            //    foreach (ListViewItem items in lvselectedproduct.Items)
            //    {
            //        list.Add((ListViewItem)items.Clone());
            //    }

            //    Oder oder = new Oder();
            //    oder.SetListViewItem(list);
            //    oder.Show();
            //}

            if (lvselectedproduct.Items.Count <= 0)
            {
                return;
            }
            else
            {
                int IdUser = Sigin.ID;
                DateTime current = DateTime.Now;
                string currentday = current.ToString("dd-MM-yyyy HH:mm:ss");

                foreach(ListViewItem item in lvselectedproduct.Items)
                {
                    int gia = int.Parse(item.SubItems[2].Text);
                    int soluong = int.Parse(item.SubItems[3].Text);
                    string tensp = item.SubItems[1].Text;
                    string findidSp = "select ID from SanPham where TenSP = '" + tensp + "'";
                    SqlDataReader readerIDsp = connection.Query(findidSp);
                    int IdSP = 0;
                    if (readerIDsp.Read())
                    {
                        IdSP = readerIDsp.GetInt32(0);
                    }
                    readerIDsp.Close();
                    string insertDonhang = "INSERT INTO DonHang (ID_USer, ID_SanPham) VALUES (@userid, @spid)";
                    using (SqlCommand cmd = new SqlCommand(insertDonhang, connection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("userid", IdUser);
                        cmd.Parameters.AddWithValue("spid", IdSP +"");

                        int results = cmd.ExecuteNonQuery();
                    }
                    string iddonhang = "select ID from DonHang where ID_User = '" + IdUser + "' AND ID_SanPham = '" + IdSP + "'";
                    SqlDataReader readerIDdh = connection.Query(iddonhang);
                    int IdDH = 0;
                    if (readerIDdh.Read())
                    {
                        IdDH = readerIDdh.GetInt32(0);
                    }
                    readerIDdh.Close();
                    string insertchitiet = "INSERT INTO ChiTietDonHang (ID_DonHang, SoLuong, Ngay, TongTien) VALUES (@id_donhang, @soluong, @ngay, @tongtien)";
                    int tongtien = soluong * gia;
                    using (SqlCommand cmds = new SqlCommand(insertchitiet, connection.GetConnection()))
                    {
                        cmds.Parameters.AddWithValue("id_donhang",IdDH);
                        cmds.Parameters.AddWithValue("soluong", soluong.ToString());
                        cmds.Parameters.AddWithValue("ngay", currentday);
                        cmds.Parameters.AddWithValue("tongtien", tongtien.ToString());

                        int result = cmds.ExecuteNonQuery();
                    }


                }
                this.Hide();
                Oder oder = new Oder();
                oder.Show();
            }

            }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex == -1)
            {
                return;
            }
            string tendanhmuc = cboDanhMuc.Text;
            string listsp = "SELECT TenSP, DonGia FROM SanPham INNER JOIN DanhMuc ON SanPham.ID_DanhMuc = DanhMuc.ID WHERE Ten_DM = '" + tendanhmuc + "'";
            SqlDataReader reader = connection.Query(listsp);
            int i = 1;
            //
            lvProduct.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(i + "");
                lv.SubItems.Add(reader.GetString(0));
                lv.SubItems.Add(reader.GetInt32(1) + "");
                lvProduct.Items.Add(lv);

                i++;
            }
            reader.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sigin sigin = new Sigin();
            sigin.Show();
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //cach2
        //private int selectedQuantity()
        //{
        //    int quantity = 0;
        //    string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng:", "Chọn số lượng", "1");
        //    if (!int.TryParse(input, out quantity) || quantity <= 0)
        //    {
        //        MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        quantity = 0;
        //    }
        //    else
        //    {
        //        quantity = int.Parse(input);
        //    }
        //    return quantity;
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                ListViewItem selecteditems = lvProduct.SelectedItems[0];
                string tenSp = selecteditems.SubItems[1].Text;
                string dongia = selecteditems.SubItems[2].Text;
                int check = 0;
                foreach (ListViewItem item in lvselectedproduct.Items)
                {
                    if (tenSp == item.SubItems[1].Text)
                    {
                        int soluong = int.Parse(item.SubItems[3].Text) + 1;
                        item.SubItems[3].Text = soluong.ToString();
                        check = 1;
                        break;
                    }
                }

                if (check == 0)
                {
                    int count = lvselectedproduct.Items.Count + 1;
                    ListViewItem lv = new ListViewItem(count + "");
                    lv.SubItems.Add(tenSp);
                    lv.SubItems.Add(dongia);
                    lv.SubItems.Add(1 + "");

                    lvselectedproduct.Items.Add(lv);
                }
            }

            //cach 2 
            //if (lvProduct.SelectedItems.Count <= 0)
            //{
            //    return;
            //}
            //else
            //{
            //    int quantity = selectedQuantity();
            //    if(quantity > 0)
            //    {
            //        ListViewItem selecteditems = lvProduct.SelectedItems[0];
            //        string tenSp = selecteditems.SubItems[1].Text;
            //        string dongia = selecteditems.SubItems[2].Text;
            //        int check = 0;
            //        foreach (ListViewItem item in lvselectedproduct.Items)
            //        {
            //            if (tenSp == item.SubItems[1].Text)
            //            {
            //                int soluong = int.Parse(item.SubItems[3].Text) + quantity;
            //                item.SubItems[3].Text = soluong.ToString();
            //                check = 1;
            //                break;
            //            }
            //        }

            //        if (check == 0)
            //        {
            //            int count = lvselectedproduct.Items.Count + 1;
            //            ListViewItem lv = new ListViewItem(count + "");
            //            lv.SubItems.Add(tenSp);
            //            lv.SubItems.Add(dongia);
            //            lv.SubItems.Add(quantity +"");

            //            lvselectedproduct.Items.Add(lv);
            //        }
            //    }
            //}
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (lvselectedproduct.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                ListViewItem selecteditems = lvselectedproduct.SelectedItems[0];
                int soluong = int.Parse(selecteditems.SubItems[3].Text) - 1;
                if (soluong == 0)
                {
                    lvselectedproduct.Items.Remove(selecteditems);
                }
                else
                {
                    selecteditems.SubItems[3].Text = soluong.ToString();
                }
            }
        }

        private void lvselectedproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
