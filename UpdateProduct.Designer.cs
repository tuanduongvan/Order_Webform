namespace QL_BanHang
{
    partial class UpdateProduct
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
            label2 = new Label();
            txtNamePtoduct = new TextBox();
            txtprice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Back = new Button();
            Update = new Button();
            cboCatalog = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 35);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 0;
            label1.Text = "Update Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(87, 113);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 1;
            label2.Text = "Name Product: ";
            // 
            // txtNamePtoduct
            // 
            txtNamePtoduct.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNamePtoduct.Location = new Point(312, 117);
            txtNamePtoduct.Name = "txtNamePtoduct";
            txtNamePtoduct.Size = new Size(324, 30);
            txtNamePtoduct.TabIndex = 2;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtprice.Location = new Point(312, 183);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(324, 30);
            txtprice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(192, 183);
            label3.Name = "label3";
            label3.Size = new Size(85, 32);
            label3.TabIndex = 3;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(161, 241);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 5;
            label4.Text = "Catalog:";
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ControlDarkDark;
            Back.Cursor = Cursors.Hand;
            Back.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Back.Location = new Point(161, 339);
            Back.Name = "Back";
            Back.Size = new Size(142, 53);
            Back.TabIndex = 7;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ControlDarkDark;
            Update.Cursor = Cursors.Hand;
            Update.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Update.Location = new Point(494, 339);
            Update.Name = "Update";
            Update.Size = new Size(142, 53);
            Update.TabIndex = 8;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // cboCatalog
            // 
            cboCatalog.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboCatalog.FormattingEnabled = true;
            cboCatalog.Location = new Point(312, 245);
            cboCatalog.Name = "cboCatalog";
            cboCatalog.Size = new Size(323, 31);
            cboCatalog.TabIndex = 9;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboCatalog);
            Controls.Add(Update);
            Controls.Add(Back);
            Controls.Add(label4);
            Controls.Add(txtprice);
            Controls.Add(label3);
            Controls.Add(txtNamePtoduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNamePtoduct;
        private TextBox txtprice;
        private Label label3;
        private Label label4;
        private Button Back;
        private Button Update;
        private ComboBox cboCatalog;
    }
}