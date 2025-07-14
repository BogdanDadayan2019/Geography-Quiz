namespace Bogdan_Dadaian_Quiz_Software
{
    partial class RegistrationForm
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
            groupBox1 = new GroupBox();
            btnAbbrechenRegistration = new Button();
            btnRegistaration = new Button();
            label4 = new Label();
            label1 = new Label();
            tbRegistration = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbbrechenRegistration);
            groupBox1.Controls.Add(btnRegistaration);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbRegistration);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 170);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnAbbrechenRegistration
            // 
            btnAbbrechenRegistration.Location = new Point(117, 118);
            btnAbbrechenRegistration.Name = "btnAbbrechenRegistration";
            btnAbbrechenRegistration.Size = new Size(90, 23);
            btnAbbrechenRegistration.TabIndex = 14;
            btnAbbrechenRegistration.Text = "Abbrechen";
            btnAbbrechenRegistration.UseVisualStyleBackColor = true;
            btnAbbrechenRegistration.Click += btnAbbrechenRegistration_Click;
            // 
            // btnRegistaration
            // 
            btnRegistaration.Location = new Point(21, 118);
            btnRegistaration.Name = "btnRegistaration";
            btnRegistaration.Size = new Size(90, 23);
            btnRegistaration.TabIndex = 13;
            btnRegistaration.Text = "Bestätigen";
            btnRegistaration.UseVisualStyleBackColor = true;
            btnRegistaration.Click += btnRegistaration_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 19);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 12;
            label4.Text = "Registration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 62);
            label1.Name = "label1";
            label1.Size = new Size(304, 15);
            label1.TabIndex = 8;
            label1.Text = "Bitte geben Sie Ihren Namen ein, um sich zu registrieren.";
            // 
            // tbRegistration
            // 
            tbRegistration.Location = new Point(21, 89);
            tbRegistration.Name = "tbRegistration";
            tbRegistration.Size = new Size(237, 23);
            tbRegistration.TabIndex = 7;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 187);
            Controls.Add(groupBox1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistaration;
        private Label label4;
        private Label label1;
        private TextBox tbRegistration;
        private Button btnAbbrechenRegistration;
    }
}