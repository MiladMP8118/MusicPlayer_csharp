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
            listBox1.Location = new Point(168, 7);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 104);
            listBox1.TabIndex = 1;
            // 
            // btnPreview
            // 
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.Location = new Point(168, 124);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(76, 29);
            btnPreview.TabIndex = 2;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Location = new Point(250, 124);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(76, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.Location = new Point(332, 124);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(76, 29);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Cursor = Cursors.Hand;
            btnStop.Location = new Point(414, 124);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(76, 29);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 166);
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
    }
}
