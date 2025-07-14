namespace Bogdan_Dadaian_Quiz_Software.Forms
{
    partial class RatingForm
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
            lbRating = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbRating);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 444);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lbRating
            // 
            lbRating.FormattingEnabled = true;
            lbRating.ItemHeight = 15;
            lbRating.Location = new Point(6, 22);
            lbRating.Name = "lbRating";
            lbRating.Size = new Size(415, 409);
            lbRating.TabIndex = 0;
            // 
            // RatingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 468);
            Controls.Add(groupBox1);
            Name = "RatingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rating";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lbRating;
    }
}