namespace wupi
{
    partial class frm_wallpaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_wallpaper));
            this.pbar_download = new System.Windows.Forms.ProgressBar();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_link = new System.Windows.Forms.Button();
            this.btn_wallpaper = new System.Windows.Forms.Button();
            this.pcr_picture = new System.Windows.Forms.PictureBox();
            this.pcr_fullScreen = new System.Windows.Forms.PictureBox();
            this.pcr_desktop = new System.Windows.Forms.PictureBox();
            this.tp_tools = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_fullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_desktop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbar_download
            // 
            this.pbar_download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbar_download.Location = new System.Drawing.Point(-1, -1);
            this.pbar_download.Margin = new System.Windows.Forms.Padding(4);
            this.pbar_download.Name = "pbar_download";
            this.pbar_download.Size = new System.Drawing.Size(701, 12);
            this.pbar_download.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Location = new System.Drawing.Point(170, 28);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(113, 33);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.btn_back);
            this.pnl_bottom.Controls.Add(this.btn_save);
            this.pnl_bottom.Controls.Add(this.btn_link);
            this.pnl_bottom.Controls.Add(this.btn_wallpaper);
            this.pnl_bottom.Controls.Add(this.btn_refresh);
            this.pnl_bottom.Controls.Add(this.pbar_download);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 298);
            this.pnl_bottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(699, 76);
            this.pnl_bottom.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Enabled = false;
            this.btn_back.Location = new System.Drawing.Point(49, 28);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(113, 33);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Geri Al";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(534, 28);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 33);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_link
            // 
            this.btn_link.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link.Enabled = false;
            this.btn_link.Location = new System.Drawing.Point(413, 28);
            this.btn_link.Margin = new System.Windows.Forms.Padding(4);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(113, 33);
            this.btn_link.TabIndex = 4;
            this.btn_link.Text = "Linki Kopyala";
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // btn_wallpaper
            // 
            this.btn_wallpaper.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_wallpaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wallpaper.Enabled = false;
            this.btn_wallpaper.Location = new System.Drawing.Point(291, 28);
            this.btn_wallpaper.Margin = new System.Windows.Forms.Padding(4);
            this.btn_wallpaper.Name = "btn_wallpaper";
            this.btn_wallpaper.Size = new System.Drawing.Size(113, 33);
            this.btn_wallpaper.TabIndex = 3;
            this.btn_wallpaper.Text = "Arka Plan Yap";
            this.btn_wallpaper.UseVisualStyleBackColor = true;
            this.btn_wallpaper.Click += new System.EventHandler(this.btn_wallpaper_Click);
            // 
            // pcr_picture
            // 
            this.pcr_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcr_picture.ErrorImage = null;
            this.pcr_picture.InitialImage = null;
            this.pcr_picture.Location = new System.Drawing.Point(0, 0);
            this.pcr_picture.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_picture.Name = "pcr_picture";
            this.pcr_picture.Size = new System.Drawing.Size(699, 298);
            this.pcr_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_picture.TabIndex = 4;
            this.pcr_picture.TabStop = false;
            this.pcr_picture.DragOver += new System.Windows.Forms.DragEventHandler(this.pcr_picture_DragOver);
            this.pcr_picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcr_picture_MouseDown);
            // 
            // pcr_fullScreen
            // 
            this.pcr_fullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcr_fullScreen.BackColor = System.Drawing.Color.Transparent;
            this.pcr_fullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_fullScreen.Image = global::wupi.Properties.Resources.tamEkran;
            this.pcr_fullScreen.Location = new System.Drawing.Point(645, 10);
            this.pcr_fullScreen.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_fullScreen.Name = "pcr_fullScreen";
            this.pcr_fullScreen.Size = new System.Drawing.Size(37, 34);
            this.pcr_fullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_fullScreen.TabIndex = 6;
            this.pcr_fullScreen.TabStop = false;
            this.tp_tools.SetToolTip(this.pcr_fullScreen, "Tam Ekran");
            this.pcr_fullScreen.Click += new System.EventHandler(this.pcr_fullScreen_Click);
            // 
            // pcr_desktop
            // 
            this.pcr_desktop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcr_desktop.BackColor = System.Drawing.Color.Transparent;
            this.pcr_desktop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_desktop.Image = global::wupi.Properties.Resources.masaustuGoster;
            this.pcr_desktop.Location = new System.Drawing.Point(573, 10);
            this.pcr_desktop.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_desktop.Name = "pcr_desktop";
            this.pcr_desktop.Size = new System.Drawing.Size(64, 34);
            this.pcr_desktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_desktop.TabIndex = 5;
            this.pcr_desktop.TabStop = false;
            this.tp_tools.SetToolTip(this.pcr_desktop, "Masaüstünü Göster");
            this.pcr_desktop.Click += new System.EventHandler(this.pcr_desktop_Click);
            // 
            // frm_wallpaper
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 374);
            this.Controls.Add(this.pcr_fullScreen);
            this.Controls.Add(this.pcr_desktop);
            this.Controls.Add(this.pcr_picture);
            this.Controls.Add(this.pnl_bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(634, 350);
            this.Name = "frm_wallpaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wupi - Wallhaven Wallpapers";
            this.pnl_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_fullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_desktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbar_download;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.PictureBox pcr_picture;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Button btn_wallpaper;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pcr_desktop;
        private System.Windows.Forms.PictureBox pcr_fullScreen;
        private System.Windows.Forms.ToolTip tp_tools;
    }
}

