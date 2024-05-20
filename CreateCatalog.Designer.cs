namespace QL_BanHang
{
    partial class CreateCatalog
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
            txtName = new MaskedTextBox();
            Back = new Button();
            Create = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(218, 23);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 0;
            label1.Text = "Create Catalog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 101);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Name Catalog: ";
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(287, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 34);
            txtName.TabIndex = 2;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.AppWorkspace;
            Back.Cursor = Cursors.Hand;
            Back.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Back.Location = new Point(115, 196);
            Back.Name = "Back";
            Back.Size = new Size(126, 47);
            Back.TabIndex = 3;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Create
            // 
            Create.BackColor = SystemColors.AppWorkspace;
            Create.Cursor = Cursors.Hand;
            Create.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Create.Location = new Point(430, 196);
            Create.Name = "Create";
            Create.Size = new Size(126, 47);
            Create.TabIndex = 4;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // CreateCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 301);
            Controls.Add(Create);
            Controls.Add(Back);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateCatalog";
            Text = "CreateCatalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txtName;
        private Button Back;
        private Button Create;
    }
}