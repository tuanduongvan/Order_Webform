namespace QL_BanHang
{
    partial class Sigin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 92);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "UserName: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(108, 178);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(276, 90);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(285, 34);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(276, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(285, 34);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(169, 284);
            button1.Name = "button1";
            button1.Size = new Size(130, 54);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(318, 296);
            label3.Name = "label3";
            label3.Size = new Size(348, 32);
            label3.TabIndex = 5;
            label3.Text = "You don't have an account: ";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(658, 284);
            button2.Name = "button2";
            button2.Size = new Size(130, 54);
            button2.TabIndex = 6;
            button2.Text = "Sigup";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(354, 18);
            label4.Name = "label4";
            label4.Size = new Size(102, 38);
            label4.TabIndex = 7;
            label4.Text = "Login";
            // 
            // Sigin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(911, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Sigin";
            Text = "Signin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label4;
    }
}
