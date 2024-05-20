namespace QL_BanHang
{
    partial class ViewProduct
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
            lvSanpham = new ListView();
            STT = new ColumnHeader();
            TenSP = new ColumnHeader();
            Dongia = new ColumnHeader();
            Danhmuc = new ColumnHeader();
            Update = new ColumnHeader();
            Delete = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lvSanpham
            // 
            lvSanpham.Columns.AddRange(new ColumnHeader[] { STT, TenSP, Dongia, Danhmuc, Update, Delete });
            lvSanpham.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lvSanpham.FullRowSelect = true;
            lvSanpham.GridLines = true;
            lvSanpham.Location = new Point(103, 50);
            lvSanpham.Name = "lvSanpham";
            lvSanpham.Size = new Size(602, 325);
            lvSanpham.TabIndex = 0;
            lvSanpham.UseCompatibleStateImageBehavior = false;
            lvSanpham.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            // 
            // TenSP
            // 
            TenSP.Text = "Tên Sản Phẩm";
            TenSP.TextAlign = HorizontalAlignment.Center;
            TenSP.Width = 140;
            // 
            // Dongia
            // 
            Dongia.Text = "Đơn Giá";
            Dongia.TextAlign = HorizontalAlignment.Center;
            Dongia.Width = 120;
            // 
            // Danhmuc
            // 
            Danhmuc.Text = "Danh Mục";
            Danhmuc.TextAlign = HorizontalAlignment.Center;
            Danhmuc.Width = 120;
            // 
            // Update
            // 
            Update.Text = "Update";
            Update.TextAlign = HorizontalAlignment.Center;
            Update.Width = 80;
            // 
            // Delete
            // 
            Delete.Text = "Delete";
            Delete.TextAlign = HorizontalAlignment.Center;
            Delete.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 38);
            label1.TabIndex = 1;
            label1.Text = "Danh Sach San Pham";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(554, 381);
            button1.Name = "button1";
            button1.Size = new Size(151, 57);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lvSanpham);
            Name = "ViewProduct";
            Text = "ViewProduct";
            Load += ViewProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvSanpham;
        private ColumnHeader STT;
        private ColumnHeader TenSP;
        private ColumnHeader Dongia;
        private ColumnHeader Danhmuc;
        private ColumnHeader Update;
        private ColumnHeader Delete;
        private Label label1;
        private Button button1;
    }
}