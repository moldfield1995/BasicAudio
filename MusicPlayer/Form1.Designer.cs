namespace MusicPlayer
{
    partial class MusicPlayer
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
            if (disposing)
            {
                if (components != null)
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ListSongName = new System.Windows.Forms.ListBox();
            this.tracker = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tracker)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Location = new System.Drawing.Point(12, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(94, 11);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ListSongName
            // 
            this.ListSongName.AllowDrop = true;
            this.ListSongName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListSongName.ForeColor = System.Drawing.SystemColors.Info;
            this.ListSongName.FormattingEnabled = true;
            this.ListSongName.Location = new System.Drawing.Point(30, 81);
            this.ListSongName.Name = "ListSongName";
            this.ListSongName.Size = new System.Drawing.Size(129, 160);
            this.ListSongName.TabIndex = 2;
            this.ListSongName.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListSongName_DragDrop);
            this.ListSongName.DragOver += new System.Windows.Forms.DragEventHandler(this.ListSongName_DragOver);
            // 
            // tracker
            // 
            this.tracker.CausesValidation = false;
            this.tracker.LargeChange = 0;
            this.tracker.Location = new System.Drawing.Point(197, 11);
            this.tracker.Maximum = 20000;
            this.tracker.Name = "tracker";
            this.tracker.Size = new System.Drawing.Size(237, 45);
            this.tracker.SmallChange = 0;
            this.tracker.TabIndex = 3;
            this.tracker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tracker_MouseDown);
            this.tracker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tracker_MouseUp);
            // 
            // MusicPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(558, 302);
            this.Controls.Add(this.tracker);
            this.Controls.Add(this.ListSongName);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "MusicPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TrackBar tracker;
        private System.Windows.Forms.ListBox ListSongName;
    }
}

