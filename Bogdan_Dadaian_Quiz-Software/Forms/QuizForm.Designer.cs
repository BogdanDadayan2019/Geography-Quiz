namespace Bogdan_Dadaian_Quiz_Software.Forms
{
    partial class QuizForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            labelFeedback = new Label();
            label = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            labelFrageCount = new Label();
            rbAntwort_4 = new RadioButton();
            rbAntwort_3 = new RadioButton();
            rbAntwort_2 = new RadioButton();
            rbAntwort_1 = new RadioButton();
            btnBestaetigen = new Button();
            btnUeberspringen = new Button();
            groupBox2 = new GroupBox();
            pbFlagge = new PictureBox();
            label5 = new Label();
            labelFrage_1 = new Label();
            labelFrage_2 = new Label();
            label3 = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFlagge).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 690F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(426, 571);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFeedback);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelFrageCount);
            groupBox1.Controls.Add(rbAntwort_4);
            groupBox1.Controls.Add(rbAntwort_3);
            groupBox1.Controls.Add(rbAntwort_2);
            groupBox1.Controls.Add(rbAntwort_1);
            groupBox1.Controls.Add(btnBestaetigen);
            groupBox1.Controls.Add(btnUeberspringen);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(-336, -56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 627);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // labelFeedback
            // 
            labelFeedback.AutoSize = true;
            labelFeedback.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFeedback.Location = new Point(533, 497);
            labelFeedback.Name = "labelFeedback";
            labelFeedback.Size = new Size(137, 40);
            labelFeedback.TabIndex = 5;
            labelFeedback.Text = "Feedback";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(505, 364);
            label.Name = "label";
            label.Size = new Size(0, 15);
            label.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(407, 556);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(407, 493);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(407, 429);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(407, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(935, 19);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Frage:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(984, 19);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 12;
            label1.Text = "/ 15";
            // 
            // labelFrageCount
            // 
            labelFrageCount.AutoSize = true;
            labelFrageCount.Location = new Point(970, 19);
            labelFrageCount.Name = "labelFrageCount";
            labelFrageCount.Size = new Size(13, 15);
            labelFrageCount.TabIndex = 11;
            labelFrageCount.Text = "1";
            // 
            // rbAntwort_4
            // 
            rbAntwort_4.AutoSize = true;
            rbAntwort_4.Font = new Font("Segoe UI", 14.25F);
            rbAntwort_4.Location = new Point(370, 582);
            rbAntwort_4.Name = "rbAntwort_4";
            rbAntwort_4.Size = new Size(14, 13);
            rbAntwort_4.TabIndex = 10;
            rbAntwort_4.TabStop = true;
            rbAntwort_4.UseVisualStyleBackColor = true;
            // 
            // rbAntwort_3
            // 
            rbAntwort_3.AutoSize = true;
            rbAntwort_3.Font = new Font("Segoe UI", 14.25F);
            rbAntwort_3.Location = new Point(370, 515);
            rbAntwort_3.Name = "rbAntwort_3";
            rbAntwort_3.Size = new Size(14, 13);
            rbAntwort_3.TabIndex = 9;
            rbAntwort_3.TabStop = true;
            rbAntwort_3.UseVisualStyleBackColor = true;
            // 
            // rbAntwort_2
            // 
            rbAntwort_2.AutoSize = true;
            rbAntwort_2.Font = new Font("Segoe UI", 14.25F);
            rbAntwort_2.Location = new Point(370, 452);
            rbAntwort_2.Name = "rbAntwort_2";
            rbAntwort_2.Size = new Size(14, 13);
            rbAntwort_2.TabIndex = 8;
            rbAntwort_2.TabStop = true;
            rbAntwort_2.UseVisualStyleBackColor = true;
            // 
            // rbAntwort_1
            // 
            rbAntwort_1.AutoSize = true;
            rbAntwort_1.Font = new Font("Segoe UI", 14.25F);
            rbAntwort_1.Location = new Point(370, 387);
            rbAntwort_1.Name = "rbAntwort_1";
            rbAntwort_1.Size = new Size(14, 13);
            rbAntwort_1.TabIndex = 7;
            rbAntwort_1.TabStop = true;
            rbAntwort_1.UseVisualStyleBackColor = true;
            // 
            // btnBestaetigen
            // 
            btnBestaetigen.Font = new Font("Segoe UI", 11.25F);
            btnBestaetigen.Location = new Point(531, 586);
            btnBestaetigen.Name = "btnBestaetigen";
            btnBestaetigen.Size = new Size(195, 29);
            btnBestaetigen.TabIndex = 6;
            btnBestaetigen.Text = "Bestätigen";
            btnBestaetigen.UseVisualStyleBackColor = true;
            btnBestaetigen.Click += btnBestaetigen_Click;
            // 
            // btnUeberspringen
            // 
            btnUeberspringen.Font = new Font("Segoe UI", 11.25F);
            btnUeberspringen.Location = new Point(531, 551);
            btnUeberspringen.Name = "btnUeberspringen";
            btnUeberspringen.Size = new Size(195, 29);
            btnUeberspringen.TabIndex = 5;
            btnUeberspringen.Text = "Überspringen";
            btnUeberspringen.UseVisualStyleBackColor = true;
            btnUeberspringen.Click += btnUeberspringen_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbFlagge);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(labelFrage_1);
            groupBox2.Controls.Add(labelFrage_2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(370, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 272);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // pbFlagge
            // 
            pbFlagge.Location = new Point(0, 9);
            pbFlagge.Name = "pbFlagge";
            pbFlagge.Size = new Size(356, 263);
            pbFlagge.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlagge.TabIndex = 4;
            pbFlagge.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 21.75F);
            label5.Location = new Point(6, 158);
            label5.Name = "label5";
            label5.Size = new Size(62, 33);
            label5.TabIndex = 3;
            label5.Text = "von";
            // 
            // labelFrage_1
            // 
            labelFrage_1.AutoSize = true;
            labelFrage_1.Font = new Font("Microsoft Sans Serif", 21.75F);
            labelFrage_1.Location = new Point(6, 85);
            labelFrage_1.Name = "labelFrage_1";
            labelFrage_1.Size = new Size(77, 33);
            labelFrage_1.TabIndex = 2;
            labelFrage_1.Text = "label";
            // 
            // labelFrage_2
            // 
            labelFrage_2.AutoSize = true;
            labelFrage_2.Font = new Font("Microsoft Sans Serif", 21.75F);
            labelFrage_2.Location = new Point(6, 226);
            labelFrage_2.Name = "labelFrage_2";
            labelFrage_2.Size = new Size(77, 33);
            labelFrage_2.TabIndex = 1;
            labelFrage_2.Text = "label";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(111, 33);
            label3.TabIndex = 0;
            label3.Text = "Was ist";
            // 
            // Timer
            // 
            Timer.Tick += FeedbackTimer_Tick;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 571);
            Controls.Add(tableLayoutPanel1);
            Name = "QuizForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            FormClosed += QuizForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFlagge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBestaetigen;
        private System.Windows.Forms.Button btnUeberspringen;
        private System.Windows.Forms.RadioButton rbAntwort_1;
        private System.Windows.Forms.RadioButton rbAntwort_2;
        private System.Windows.Forms.RadioButton rbAntwort_3;
        private System.Windows.Forms.RadioButton rbAntwort_4;
        private Label labelFrageCount;
        private Label label2;
        private Label label1;
        private Label labelFrage_2;
        private Label label3;
        private Label label5;
        private Label labelFrage_1;
        private PictureBox pbFlagge;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label;
        private Label labelFeedback;
        private System.Windows.Forms.Timer Timer;
    }
}