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
    public partial class Oder : Form
    {
        public static DbConnection connection;
        public Oder()
        {
            connection = new DbConnection();    
            InitializeComponent();
        }

        //public void SetListViewItem(List<ListViewItem> listitems)
        //{
        //    int tongtien = 0;
        //    int gia, soluong;
        //    foreach (ListViewItem item in listitems)
        //    {
        //        lvconfirmoder.Items.Add((ListViewItem)item.Clone());
        //        gia = int.Parse(item.SubItems[2].Text);
        //        soluong = int.Parse(item.SubItems[3].Text);
        //        tongtien += gia * soluong;
        //    }

        //    DateTime currentday = DateTime.Now;
        //    string formatday = currentday.ToString("dd/MM/yyy");
        //    lbngay.Text = formatday;

        //    string thanhtoan = tongtien.ToString() + " dong";
        //    lbTongtien.Text = thanhtoan;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //List<ListViewItem> listitems = new List<ListViewItem>();
            //foreach (ListViewItem item in lvconfirmoder.Items)
            //{
            //    listitems.Add((ListViewItem)item.Clone());
            //}
            this.Hide();
            UserPage userPage = new UserPage();
            //userPage.Reload(listitems);
            userPage.Show();
        }

        //private void btnOder_Click(object sender, EventArgs e)
        //{
        //    if (lvconfirmoder.Items.Count <= 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        int Iduser = Sigin.ID;
        //        DateTime currentday = DateTime.Now;
        //        string formatday = currentday.ToString("dd/MM/yyy");
        //        foreach (ListViewItem item in lvconfirmoder.Items)
        //        {

        //        }
        //    }
        //}

        private void Oder_Load(object sender, EventArgs e)
        {
            int IdUser = Sigin.ID;
            List<Tuple<int, string>> pairs = new List<Tuple<int, string>>();
            string IDdonhang = "SELECT DonHang.ID, SanPham.TenSP FROM DonHang INNER JOIN SanPham ON Donhang.ID_SanPham = SanPham.ID Where ID_User = " + IdUser;
            SqlDataReader reader = connection.Query(IDdonhang);
            while(reader.Read())
            {
                pairs.Add(new Tuple<int, string>(reader.GetInt32(0), reader.GetString(1)));
            }

            reader.Close();

            DateTime current = DateTime.Now;
            string currentday = current.ToString("dd-MM-yyyy HH:mm:ss");
            string currentdays = current.ToString("dd-MM-yyyy");
            lbngay.Text = currentdays;
            int i = 1;
            int tongtien = 0;
            foreach(var pair in pairs)
            {
                string sanpham = "Select DonGia From SanPham Where TenSP = '" + pair.Item2 + "'";
                SqlDataReader gia = connection.Query(sanpham);
                string dongia = "";
                if(gia.Read())
                {
                    dongia = gia.GetInt32(0) +"";
                }
                gia.Close();
                string search = "SELECT SoLuong, TongTien From ChiTietDonHang Where ID_DonHang = "+pair.Item1+" And Ngay = '" + currentday + "'";
                SqlDataReader readers = connection.Query(search);
                if(readers.Read())
                {
                    ListViewItem lv = new ListViewItem(i+"");
                    lv.SubItems.Add(pair.Item2);
                    lv.SubItems.Add(dongia);
                    lv.SubItems.Add(readers.GetInt32(0) +"");
                    lv.SubItems.Add(readers.GetInt32(1) + "");
                    tongtien += readers.GetInt32(1);

                    lvconfirmoder.Items.Add(lv);
                }
                readers.Close();
                i++;
            }
            lbTongtien.Text = tongtien.ToString() + " dong";
        }
    }
}
