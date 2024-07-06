namespace MusicPlayerv1
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            btnPreview = new Button();
            btnNext = new Button();
            btnPlay = new Button();
            btnStop = new Button();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(162, 7);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(349, 84);
            listBox1.TabIndex = 1;
            // 
            // btnPreview
            // 
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.Font = new Font("Segoe UI", 7.8F);
            btnPreview.Location = new Point(162, 129);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(65, 29);
            btnPreview.TabIndex = 2;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("Segoe UI", 7.8F);
            btnNext.Location = new Point(233, 129);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(65, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.Font = new Font("Segoe UI", 7.8F);
            btnPlay.Location = new Point(304, 129);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(65, 29);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Cursor = Cursors.Hand;
            btnStop.Font = new Font("Segoe UI", 7.8F);
            btnStop.Location = new Point(375, 129);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(65, 29);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.Font = new Font("Segoe UI", 7.8F);
            btnBrowse.Location = new Point(446, 129);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(65, 29);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 166);
            Controls.Add(btnBrowse);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(btnNext);
            Controls.Add(btnPreview);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button btnPreview;
        private Button btnNext;
        private Button btnPlay;
        private Button btnStop;
        private Button btnBrowse;
    }
}
