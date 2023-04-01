namespace Music_Player
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_musics = new System.Windows.Forms.ListBox();
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.musicSoundTrackbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.musicSoundTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_musics
            // 
            this.listBox_musics.FormattingEnabled = true;
            this.listBox_musics.ItemHeight = 16;
            this.listBox_musics.Location = new System.Drawing.Point(170, 12);
            this.listBox_musics.Name = "listBox_musics";
            this.listBox_musics.Size = new System.Drawing.Size(495, 260);
            this.listBox_musics.TabIndex = 0;
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.ImageIndex = 0;
            this.btn_selectFolder.ImageList = this.imageList1;
            this.btn_selectFolder.Location = new System.Drawing.Point(12, 12);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(139, 60);
            this.btn_selectFolder.TabIndex = 1;
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.btn_selectFolder_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "favicon (2).ico");
            this.imageList1.Images.SetKeyName(1, "favicon (3).ico");
            this.imageList1.Images.SetKeyName(2, "favicon (5).ico");
            this.imageList1.Images.SetKeyName(3, "favicon (6).ico");
            // 
            // btn_play
            // 
            this.btn_play.ImageIndex = 1;
            this.btn_play.ImageList = this.imageList1;
            this.btn_play.Location = new System.Drawing.Point(13, 78);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(138, 60);
            this.btn_play.TabIndex = 2;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.ImageIndex = 2;
            this.btn_stop.ImageList = this.imageList1;
            this.btn_stop.Location = new System.Drawing.Point(12, 146);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(138, 60);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ImageIndex = 3;
            this.btn_delete.ImageList = this.imageList1;
            this.btn_delete.Location = new System.Drawing.Point(13, 212);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 60);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.folderPathLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.folderPathLabel.Location = new System.Drawing.Point(170, 288);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(0, 16);
            this.folderPathLabel.TabIndex = 5;
            // 
            // musicSoundTrackbar
            // 
            this.musicSoundTrackbar.Location = new System.Drawing.Point(170, 278);
            this.musicSoundTrackbar.Maximum = 100;
            this.musicSoundTrackbar.Name = "musicSoundTrackbar";
            this.musicSoundTrackbar.Size = new System.Drawing.Size(495, 56);
            this.musicSoundTrackbar.TabIndex = 6;
            this.musicSoundTrackbar.Value = 25;
            this.musicSoundTrackbar.Scroll += new System.EventHandler(this.musicSoundTrackbar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 314);
            this.Controls.Add(this.musicSoundTrackbar);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_selectFolder);
            this.Controls.Add(this.listBox_musics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.musicSoundTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_musics;
        private System.Windows.Forms.Button btn_selectFolder;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.TrackBar musicSoundTrackbar;
        private System.Windows.Forms.ImageList imageList1;
    }
}

