namespace Bogdan_Dadaian_Quiz_Software
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            btnRegistration = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbLogin = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnRegistration);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbLogin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 369);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(264, 126);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 23);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(21, 192);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(90, 23);
            btnRegistration.TabIndex = 9;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 32);
            label4.Name = "label4";
            label4.Size = new Size(56, 30);
            label4.TabIndex = 12;
            label4.Text = "Quiz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(21, 174);
            label3.Name = "label3";
            label3.Size = new Size(169, 15);
            label3.TabIndex = 11;
            label3.Text = "unten , um sich zu registrieren.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(21, 159);
            label2.Name = "label2";
            label2.Size = new Size(333, 15);
            label2.TabIndex = 10;
            label2.Text = "Sie sind noch nicht registriert? Klicken Sie auf die Schaltfläche ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 105);
            label1.Name = "label1";
            label1.Size = new Size(295, 15);
            label1.TabIndex = 8;
            label1.Text = "Bitte geben Sie Ihren Namen ein, um sich anzumelden.";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(21, 126);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(237, 23);
            tbLogin.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 400);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnLogin;
        private Button btnRegistration;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbLogin;
    }
}
