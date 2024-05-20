namespace QL_BanHang
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private object label1;

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
            label2 = new Label();
            button1 = new Button();
            ViewProduct = new Button();
            button4 = new Button();
            CreateCatalog = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(170, 21);
            label2.Name = "label2";
            label2.Size = new Size(426, 38);
            label2.TabIndex = 0;
            label2.Text = "Ứng dụng quản lý bán hàng";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(67, 149);
            button1.Name = "button1";
            button1.Size = new Size(156, 53);
            button1.TabIndex = 1;
            button1.Text = "Create Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewProduct
            // 
            ViewProduct.BackColor = SystemColors.ButtonShadow;
            ViewProduct.Cursor = Cursors.Hand;
            ViewProduct.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewProduct.Location = new Point(288, 149);
            ViewProduct.Name = "ViewProduct";
            ViewProduct.Size = new Size(176, 53);
            ViewProduct.TabIndex = 2;
            ViewProduct.Text = "View ListProduct";
            ViewProduct.UseVisualStyleBackColor = false;
            ViewProduct.Click += ViewProduct_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonShadow;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(519, 325);
            button4.Name = "button4";
            button4.Size = new Size(156, 53);
            button4.TabIndex = 4;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CreateCatalog
            // 
            CreateCatalog.BackColor = SystemColors.ButtonShadow;
            CreateCatalog.Cursor = Cursors.Hand;
            CreateCatalog.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateCatalog.Location = new Point(535, 149);
            CreateCatalog.Name = "CreateCatalog";
            CreateCatalog.Size = new Size(176, 53);
            CreateCatalog.TabIndex = 5;
            CreateCatalog.Text = "Create Catalog";
            CreateCatalog.UseVisualStyleBackColor = false;
            CreateCatalog.Click += CreateCatalog_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateCatalog);
            Controls.Add(button4);
            Controls.Add(ViewProduct);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private Button ViewProduct;
        private Button button4;
        private Button CreateCatalog;
    }
}