namespace QL_BanHang
{
    partial class CreateProduct
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
            txtPoductname = new TextBox();
            label3 = new Label();
            Back = new Button();
            create = new Button();
            txtprice = new TextBox();
            label4 = new Label();
            cbocatalog = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 26);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 0;
            label1.Text = "Create Product ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 106);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // txtPoductname
            // 
            txtPoductname.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPoductname.Location = new Point(326, 108);
            txtPoductname.Name = "txtPoductname";
            txtPoductname.Size = new Size(307, 34);
            txtPoductname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(135, 220);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 3;
            label3.Text = "ID Catalog:";
            // 
            // Back
            // 
            Back.BackColor = SystemColors.AppWorkspace;
            Back.Cursor = Cursors.Hand;
            Back.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Back.Location = new Point(114, 305);
            Back.Name = "Back";
            Back.Size = new Size(174, 49);
            Back.TabIndex = 5;
            Back.Text = "Back ";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // create
            // 
            create.BackColor = SystemColors.AppWorkspace;
            create.Cursor = Cursors.Hand;
            create.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            create.Location = new Point(499, 305);
            create.Name = "create";
            create.Size = new Size(174, 49);
            create.TabIndex = 6;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtprice.Location = new Point(326, 164);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(307, 34);
            txtprice.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(196, 164);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 7;
            label4.Text = "Price: ";
            // 
            // cbocatalog
            // 
            cbocatalog.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbocatalog.FormattingEnabled = true;
            cbocatalog.Location = new Point(326, 220);
            cbocatalog.Name = "cbocatalog";
            cbocatalog.Size = new Size(307, 31);
            cbocatalog.TabIndex = 9;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbocatalog);
            Controls.Add(txtprice);
            Controls.Add(label4);
            Controls.Add(create);
            Controls.Add(Back);
            Controls.Add(label3);
            Controls.Add(txtPoductname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateProduct";
            Text = "CreateProduct";
            Load += CreateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPoductname;
        private Label label3;
        private Button Back;
        private Button create;
        private TextBox txtprice;
        private Label label4;
        private ComboBox cbocatalog;
    }
}