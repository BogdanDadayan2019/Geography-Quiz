﻿namespace Bogdan_Dadaian_Quiz_Software.Forms
{
    partial class FinalForm
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
            label3 = new Label();
            labelSpielerName = new Label();
            btnPersönlichRaiting = new Button();
            btnRating = new Button();
            label5 = new Label();
            label4 = new Label();
            lblPunkten = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelSpielerName);
            groupBox1.Controls.Add(btnPersönlichRaiting);
            groupBox1.Controls.Add(btnRating);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblPunkten);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 444);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 8;
            label3.Text = "Spieler:";
            // 
            // labelSpielerName
            // 
            labelSpielerName.AutoSize = true;
            labelSpielerName.Font = new Font("Segoe UI", 15.75F);
            labelSpielerName.Location = new Point(92, 20);
            labelSpielerName.Name = "labelSpielerName";
            labelSpielerName.Size = new Size(57, 30);
            labelSpielerName.TabIndex = 7;
            labelSpielerName.Text = "label";
            // 
            // btnPersönlichRaiting
            // 
            btnPersönlichRaiting.Location = new Point(296, 399);
            btnPersönlichRaiting.Name = "btnPersönlichRaiting";
            btnPersönlichRaiting.Size = new Size(111, 23);
            btnPersönlichRaiting.TabIndex = 6;
            btnPersönlichRaiting.Text = "Meine Ergebnisse";
            btnPersönlichRaiting.UseVisualStyleBackColor = true;
            btnPersönlichRaiting.Click += btnPersönlichRaiting_Click;
            // 
            // btnRating
            // 
            btnRating.Location = new Point(19, 399);
            btnRating.Name = "btnRating";
            btnRating.Size = new Size(111, 23);
            btnRating.TabIndex = 5;
            btnRating.Text = "Rating Tabelle";
            btnRating.UseVisualStyleBackColor = true;
            btnRating.Click += btnRating_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(66, 273);
            label5.Name = "label5";
            label5.Size = new Size(303, 30);
            label5.TabIndex = 4;
            label5.Text = "Vielen Dank für Ihre Teilnahme.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(204, 206);
            label4.Name = "label4";
            label4.Size = new Size(164, 30);
            label4.TabIndex = 3;
            label4.Text = "Punkte erhalten.";
            // 
            // lblPunkten
            // 
            lblPunkten.AutoSize = true;
            lblPunkten.Font = new Font("Segoe UI", 15.75F);
            lblPunkten.Location = new Point(163, 206);
            lblPunkten.Name = "lblPunkten";
            lblPunkten.Size = new Size(35, 30);
            lblPunkten.TabIndex = 2;
            lblPunkten.Text = "99";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 206);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Sie haben ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 129);
            label1.Name = "label1";
            label1.Size = new Size(402, 47);
            label1.TabIndex = 0;
            label1.Text = "Herzlichen Glückwunsch!";
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 468);
            Controls.Add(groupBox1);
            Name = "FinalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label lblPunkten;
        private Label label2;
        private Label label1;
        private Button btnRating;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnPersönlichRaiting;
        private Label labelSpielerName;
        private Label label3;
    }
}