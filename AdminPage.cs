using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class AdminPage : Form
    {
        public static DbConnection connection;
        public AdminPage()
        {
            connection = new DbConnection();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateProduct create = new CreateProduct();
            create.Show();
        }

        private void CreateCatalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCatalog catalog = new CreateCatalog();
            catalog.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sigin sigin = new Sigin();
            sigin.Show();
        }

        private void ViewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProduct view = new ViewProduct();
            view.Show();
        }
    }
}
