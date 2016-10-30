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
                Destroy();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tracker = new System.Windows.Forms.TrackBar();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ListSongName = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracker)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Controls.Add(this.tracker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PauseButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlayButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(250, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.30769F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 30);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tracker
            // 
            this.tracker.CausesValidation = false;
            this.tracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracker.LargeChange = 0;
            this.tracker.Location = new System.Drawing.Point(3, 3);
            this.tracker.Maximum = 20000;
            this.tracker.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.tracker.MinimumSize = new System.Drawing.Size(150, 20);
            this.tracker.Name = "tracker";
            this.tracker.Size = new System.Drawing.Size(221, 24);
            this.tracker.SmallChange = 0;
            this.tracker.TabIndex = 3;
            this.tracker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tracker_MouseDown);
            this.tracker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tracker_MouseUp);
            // 
            // PauseButton
            // 
            this.PauseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PauseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseButton.Location = new System.Drawing.Point(230, 3);
            this.PauseButton.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.PauseButton.MinimumSize = new System.Drawing.Size(20, 20);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(65, 24);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.Location = new System.Drawing.Point(301, 3);
            this.PlayButton.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.PlayButton.MinimumSize = new System.Drawing.Size(20, 20);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(65, 24);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ListSongName
            // 
            this.ListSongName.AllowDrop = true;
            this.ListSongName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ListSongName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSongName.ForeColor = System.Drawing.SystemColors.Info;
            this.ListSongName.FormattingEnabled = true;
            this.ListSongName.Location = new System.Drawing.Point(0, 30);
            this.ListSongName.Margin = new System.Windows.Forms.Padding(0);
            this.ListSongName.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.ListSongName.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListSongName.Name = "ListSongName";
            this.ListSongName.Size = new System.Drawing.Size(369, 137);
            this.ListSongName.TabIndex = 2;
            this.ListSongName.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListSongName_DragDrop);
            this.ListSongName.DragOver += new System.Windows.Forms.DragEventHandler(this.ListSongName_DragOver);
            // 
            // MusicPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 167);
            this.Controls.Add(this.ListSongName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MusicPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusicPlayer_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracker)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar tracker;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.ListBox ListSongName;
        private System.Windows.Forms.Button PlayButton;
    }
}

