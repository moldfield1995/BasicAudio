﻿namespace MusicPlayer
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
                musicHandler.Destroy();
            }
            base.Dispose(disposing);
        }

        private void trackerInit()
        {
            musicHandler = new MusicHandler();
            ((System.ComponentModel.ISupportInitialize)(musicHandler.tracker)).BeginInit();
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
            musicHandler = new MusicHandler();
            ((System.ComponentModel.ISupportInitialize)(musicHandler.tracker)).BeginInit();
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
            this.ListSongName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListSongName.ForeColor = System.Drawing.SystemColors.Info;
            this.ListSongName.FormattingEnabled = true;
            this.ListSongName.Location = new System.Drawing.Point(30, 81);
            this.ListSongName.Name = "ListSongName";
            this.ListSongName.Size = new System.Drawing.Size(129, 160);
            this.ListSongName.TabIndex = 2;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(558, 302);
            this.Controls.Add(musicHandler.tracker);
            this.Controls.Add(this.ListSongName);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "MusicPlayer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(musicHandler.tracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.ListBox ListSongName;
    }
}

