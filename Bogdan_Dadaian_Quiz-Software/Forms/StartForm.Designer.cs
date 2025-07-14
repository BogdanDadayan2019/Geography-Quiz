namespace Bogdan_Dadaian_Quiz_Software.Forms
{
    partial class StartForm
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            cbContinenten = new ComboBox();
            btnBestaetigen = new Button();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            rbAntwortenHauptstaedt = new RadioButton();
            rbAntwortenFlagge = new RadioButton();
            rbAntwortenLaender = new RadioButton();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label2 = new Label();
            rbFragenLaender = new RadioButton();
            rbFragenFlagge = new RadioButton();
            rgFragenHauptstaedt = new RadioButton();
            label1 = new Label();
            btnQuizIni = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(265, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(0, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQuizIni);
            groupBox1.Controls.Add(cbContinenten);
            groupBox1.Controls.Add(btnBestaetigen);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 444);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cbContinenten
            // 
            cbContinenten.FormattingEnabled = true;
            cbContinenten.Location = new Point(54, 376);
            cbContinenten.Name = "cbContinenten";
            cbContinenten.Size = new Size(121, 23);
            cbContinenten.TabIndex = 3;
            // 
            // btnBestaetigen
            // 
            btnBestaetigen.Location = new Point(247, 375);
            btnBestaetigen.Name = "btnBestaetigen";
            btnBestaetigen.Size = new Size(121, 23);
            btnBestaetigen.TabIndex = 2;
            btnBestaetigen.Text = "Bestätigen";
            btnBestaetigen.UseVisualStyleBackColor = true;
            btnBestaetigen.Click += btnBestaetigen_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(54, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 281);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbAntwortenHauptstaedt);
            groupBox4.Controls.Add(rbAntwortenFlagge);
            groupBox4.Controls.Add(rbAntwortenLaender);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(167, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(137, 241);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Antworte:";
            // 
            // rbAntwortenHauptstaedt
            // 
            rbAntwortenHauptstaedt.AutoSize = true;
            rbAntwortenHauptstaedt.Font = new Font("Segoe UI", 11.25F);
            rbAntwortenHauptstaedt.Location = new Point(10, 118);
            rbAntwortenHauptstaedt.Name = "rbAntwortenHauptstaedt";
            rbAntwortenHauptstaedt.Size = new Size(101, 24);
            rbAntwortenHauptstaedt.TabIndex = 19;
            rbAntwortenHauptstaedt.TabStop = true;
            rbAntwortenHauptstaedt.Text = "Hauptstädt";
            rbAntwortenHauptstaedt.UseVisualStyleBackColor = true;
            rbAntwortenHauptstaedt.CheckedChanged += AntwortenRadioButton_CheckedChanged;
            // 
            // rbAntwortenFlagge
            // 
            rbAntwortenFlagge.AutoSize = true;
            rbAntwortenFlagge.Font = new Font("Segoe UI", 11.25F);
            rbAntwortenFlagge.Location = new Point(10, 77);
            rbAntwortenFlagge.Name = "rbAntwortenFlagge";
            rbAntwortenFlagge.Size = new Size(72, 24);
            rbAntwortenFlagge.TabIndex = 18;
            rbAntwortenFlagge.TabStop = true;
            rbAntwortenFlagge.Text = "Flagge";
            rbAntwortenFlagge.UseVisualStyleBackColor = true;
            rbAntwortenFlagge.CheckedChanged += AntwortenRadioButton_CheckedChanged;
            // 
            // rbAntwortenLaender
            // 
            rbAntwortenLaender.AutoSize = true;
            rbAntwortenLaender.Font = new Font("Segoe UI", 11.25F);
            rbAntwortenLaender.Location = new Point(10, 32);
            rbAntwortenLaender.Name = "rbAntwortenLaender";
            rbAntwortenLaender.Size = new Size(72, 24);
            rbAntwortenLaender.TabIndex = 17;
            rbAntwortenLaender.TabStop = true;
            rbAntwortenLaender.Text = "Länder";
            rbAntwortenLaender.UseVisualStyleBackColor = true;
            rbAntwortenLaender.CheckedChanged += AntwortenRadioButton_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, -22);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 16;
            label3.Text = "Antworten:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(rbFragenLaender);
            groupBox3.Controls.Add(rbFragenFlagge);
            groupBox3.Controls.Add(rgFragenHauptstaedt);
            groupBox3.Location = new Point(12, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(134, 241);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fragen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 19);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 8;
            // 
            // rbFragenLaender
            // 
            rbFragenLaender.AutoSize = true;
            rbFragenLaender.Font = new Font("Segoe UI", 11.25F);
            rbFragenLaender.Location = new Point(10, 34);
            rbFragenLaender.Name = "rbFragenLaender";
            rbFragenLaender.Size = new Size(72, 24);
            rbFragenLaender.TabIndex = 10;
            rbFragenLaender.TabStop = true;
            rbFragenLaender.Text = "Länder";
            rbFragenLaender.UseVisualStyleBackColor = true;
            rbFragenLaender.CheckedChanged += FragenRadioButton_CheckedChanged;
            // 
            // rgFragenFlagge
            // 
            rbFragenFlagge.AutoSize = true;
            rbFragenFlagge.Font = new Font("Segoe UI", 11.25F);
            rbFragenFlagge.Location = new Point(10, 79);
            rbFragenFlagge.Name = "rgFragenFlagge";
            rbFragenFlagge.Size = new Size(72, 24);
            rbFragenFlagge.TabIndex = 11;
            rbFragenFlagge.TabStop = true;
            rbFragenFlagge.Text = "Flagge";
            rbFragenFlagge.UseVisualStyleBackColor = true;
            rbFragenFlagge.CheckedChanged += FragenRadioButton_CheckedChanged;
            // 
            // rgFragenHauptstaedt
            // 
            rgFragenHauptstaedt.AutoSize = true;
            rgFragenHauptstaedt.Font = new Font("Segoe UI", 11.25F);
            rgFragenHauptstaedt.Location = new Point(10, 120);
            rgFragenHauptstaedt.Name = "rgFragenHauptstaedt";
            rgFragenHauptstaedt.Size = new Size(101, 24);
            rgFragenHauptstaedt.TabIndex = 12;
            rgFragenHauptstaedt.TabStop = true;
            rgFragenHauptstaedt.Text = "Hauptstädt";
            rgFragenHauptstaedt.UseVisualStyleBackColor = true;
            rgFragenHauptstaedt.CheckedChanged += FragenRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 43);
            label1.Name = "label1";
            label1.Size = new Size(292, 32);
            label1.TabIndex = 0;
            label1.Text = "Was möchten Sie spielen?";
            // 
            // btnQuizIni
            // 
            btnQuizIni.Location = new Point(54, 405);
            btnQuizIni.Name = "btnQuizIni";
            btnQuizIni.Size = new Size(121, 23);
            btnQuizIni.TabIndex = 4;
            btnQuizIni.Text = "Quiz.ini start";
            btnQuizIni.UseVisualStyleBackColor = true;
            btnQuizIni.Click += btnQuizIni_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 468);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Button btnBestaetigen;
        private RadioButton rbFragenFlagge;
        private RadioButton rbFragenLaender;
        private RadioButton rgFragenHauptstaedt;
        private GroupBox groupBox4;
        private RadioButton rbAntwortenHauptstaedt;
        private RadioButton rbAntwortenFlagge;
        private RadioButton rbAntwortenLaender;
        private Label label3;
        private GroupBox groupBox3;
        private ComboBox cbContinenten;
        private Button btnQuizIni;
    }
}