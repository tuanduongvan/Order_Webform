namespace QL_BanHang
{
    partial class Oder
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
            lvconfirmoder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            coluong = new ColumnHeader();
            Thanhtien = new ColumnHeader();
            button1 = new Button();
            label2 = new Label();
            lbngay = new Label();
            label3 = new Label();
            lbTongtien = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 0;
            label1.Text = "YOUR ODER";
            // 
            // lvconfirmoder
            // 
            lvconfirmoder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lvconfirmoder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, coluong, Thanhtien });
            lvconfirmoder.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lvconfirmoder.FullRowSelect = true;
            lvconfirmoder.GridLines = true;
            lvconfirmoder.Location = new Point(136, 113);
            lvconfirmoder.Name = "lvconfirmoder";
            lvconfirmoder.Size = new Size(520, 300);
            lvconfirmoder.TabIndex = 10;
            lvconfirmoder.UseCompatibleStateImageBehavior = false;
            lvconfirmoder.View = View.Details;
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
            // Thanhtien
            // 
            Thanhtien.Text = "Thành Tiền";
            Thanhtien.TextAlign = HorizontalAlignment.Center;
            Thanhtien.Width = 120;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(454, 511);
            button1.Name = "button1";
            button1.Size = new Size(137, 46);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 13;
            label2.Text = "Ngày: ";
            // 
            // lbngay
            // 
            lbngay.AutoSize = true;
            lbngay.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbngay.Location = new Point(293, 66);
            lbngay.Name = "lbngay";
            lbngay.Size = new Size(0, 25);
            lbngay.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(156, 441);
            label3.Name = "label3";
            label3.Size = new Size(237, 25);
            label3.TabIndex = 15;
            label3.Text = "Tổng tiền thanh toán: ";
            // 
            // lbTongtien
            // 
            lbTongtien.AutoSize = true;
            lbTongtien.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongtien.Location = new Point(493, 443);
            lbTongtien.Name = "lbTongtien";
            lbTongtien.Size = new Size(0, 23);
            lbTongtien.TabIndex = 16;
            // 
            // Oder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(lbTongtien);
            Controls.Add(label3);
            Controls.Add(lbngay);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lvconfirmoder);
            Controls.Add(label1);
            Name = "Oder";
            Text = "Oder";
            Load += Oder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvconfirmoder;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader coluong;
        private Button button1;
        private Label label2;
        private Label lbngay;
        private Label label3;
        private Label lbTongtien;
        private ColumnHeader Thanhtien;
    }
}