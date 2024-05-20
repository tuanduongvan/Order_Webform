namespace QL_BanHang
{
    partial class UserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnLogout = new Button();
            label2 = new Label();
            cboDanhMuc = new ComboBox();
            lvProduct = new ListView();
            STT = new ColumnHeader();
            TenSp = new ColumnHeader();
            Dongia = new ColumnHeader();
            label3 = new Label();
            label4 = new Label();
            lvselectedproduct = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            coluong = new ColumnHeader();
            btnOder = new Button();
            btnAdd = new Button();
            btndelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(643, 32);
            label1.TabIndex = 0;
            label1.Text = "Chào Mừng Bạn Đến Với Cửa Hàng Của Chúng Tôi\r\n";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlDark;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(704, 57);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(157, 39);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 70);
            label2.Name = "label2";
            label2.Size = new Size(228, 23);
            label2.TabIndex = 2;
            label2.Text = "Chọn danh mục sản phẩm:";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(250, 65);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(162, 31);
            cboDanhMuc.TabIndex = 3;
            cboDanhMuc.SelectedIndexChanged += cboDanhMuc_SelectedIndexChanged;
            // 
            // lvProduct
            // 
            lvProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvProduct.Columns.AddRange(new ColumnHeader[] { STT, TenSp, Dongia });
            lvProduct.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lvProduct.FullRowSelect = true;
            lvProduct.GridLines = true;
            lvProduct.Location = new Point(26, 152);
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(300, 300);
            lvProduct.TabIndex = 4;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.View = View.Details;
            lvProduct.SelectedIndexChanged += lvProduct_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            STT.Width = 50;
            // 
            // TenSp
            // 
            TenSp.Text = "Tên SP";
            TenSp.TextAlign = HorizontalAlignment.Center;
            TenSp.Width = 125;
            // 
            // Dongia
            // 
            Dongia.Text = "Đơn Giá";
            Dongia.TextAlign = HorizontalAlignment.Center;
            Dongia.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 126);
            label3.Name = "label3";
            label3.Size = new Size(179, 23);
            label3.TabIndex = 5;
            label3.Text = "Danh sách sản phẩm\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(649, 126);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 7;
            label4.Text = "Lựa chọn của bạn";
            // 
            // lvselectedproduct
            // 
            lvselectedproduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvselectedproduct.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, coluong });
            lvselectedproduct.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lvselectedproduct.FullRowSelect = true;
            lvselectedproduct.GridLines = true;
            lvselectedproduct.Location = new Point(531, 152);
            lvselectedproduct.Name = "lvselectedproduct";
            lvselectedproduct.Size = new Size(400, 300);
            lvselectedproduct.TabIndex = 8;
            lvselectedproduct.UseCompatibleStateImageBehavior = false;
            lvselectedproduct.View = View.Details;
            lvselectedproduct.SelectedIndexChanged += lvselectedproduct_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên SP";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn Giá";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 125;
            // 
            // coluong
            // 
            coluong.Text = "Số Lượng";
            coluong.TextAlign = HorizontalAlignment.Center;
            coluong.Width = 100;
            // 
            // btnOder
            // 
            btnOder.BackColor = SystemColors.ControlDarkDark;
            btnOder.Cursor = Cursors.Hand;
            btnOder.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOder.Location = new Point(670, 469);
            btnOder.Name = "btnOder";
            btnOder.Size = new Size(137, 46);
            btnOder.TabIndex = 9;
            btnOder.Text = "Order";
            btnOder.UseVisualStyleBackColor = false;
            btnOder.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDarkDark;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(362, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 46);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = SystemColors.ControlDarkDark;
            btndelete.Cursor = Cursors.Hand;
            btndelete.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(362, 292);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(126, 46);
            btndelete.TabIndex = 11;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 527);
            Controls.Add(btndelete);
            Controls.Add(btnAdd);
            Controls.Add(btnOder);
            Controls.Add(lvselectedproduct);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lvProduct);
            Controls.Add(cboDanhMuc);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private Label label2;
        private ComboBox cboDanhMuc;
        private ListView lvProduct;
        private Label label3;
        private Label label4;
        private ColumnHeader STT;
        private ColumnHeader TenSp;
        private ColumnHeader Dongia;
        private ListView lvselectedproduct;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnOder;
        private ColumnHeader coluong;
        private Button btnAdd;
        private Button btndelete;
    }
}