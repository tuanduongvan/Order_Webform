namespace QL_BanHang
{
    partial class Sigup
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
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            btnSigup = new Button();
            label5 = new Label();
            button2 = new Button();
            txtphone = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 38);
            label1.TabIndex = 0;
            label1.Text = "Sigup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 102);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 1;
            label2.Text = "UserName: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 279);
            label3.Name = "label3";
            label3.Size = new Size(200, 32);
            label3.TabIndex = 2;
            label3.Text = "Phonenumber: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(111, 168);
            label4.Name = "label4";
            label4.Size = new Size(138, 32);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(281, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(368, 34);
            txtUsername.TabIndex = 4;
            // 
            // btnSigup
            // 
            btnSigup.BackColor = SystemColors.ControlDark;
            btnSigup.Cursor = Cursors.Hand;
            btnSigup.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSigup.Location = new Point(142, 351);
            btnSigup.Name = "btnSigup";
            btnSigup.Size = new Size(131, 50);
            btnSigup.TabIndex = 7;
            btnSigup.Text = "Sigup";
            btnSigup.UseVisualStyleBackColor = false;
            btnSigup.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(311, 362);
            label5.Name = "label5";
            label5.Size = new Size(262, 32);
            label5.TabIndex = 8;
            label5.Text = "You have an account";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(579, 344);
            button2.Name = "button2";
            button2.Size = new Size(131, 50);
            button2.TabIndex = 9;
            button2.Text = "Sigin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtphone.Location = new Point(281, 281);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(368, 34);
            txtphone.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(281, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(368, 34);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirm.Location = new Point(281, 225);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(368, 34);
            txtConfirm.TabIndex = 11;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 225);
            label6.Name = "label6";
            label6.Size = new Size(246, 32);
            label6.TabIndex = 10;
            label6.Text = "Confirm Password:";
            // 
            // Sigup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConfirm);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(btnSigup);
            Controls.Add(txtPassword);
            Controls.Add(txtphone);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sigup";
            Text = "Sigup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private Button btnSigup;
        private Label label5;
        private Button button2;
        private TextBox txtphone;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Label label6;
    }
}