using Microsoft.Win32;
using Shell32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace wupi
{
    public partial class frm_wallpaper : Form
    {
        public frm_wallpaper()
        {
            InitializeComponent();

            pcr_desktop.Image = ImageBlur.Make(Properties.Resources.masaustuGoster);
            pcr_desktop.Parent = pcr_picture;

            pcr_fullScreen.Image = ImageBlur.Make(Properties.Resources.tamEkran);
            pcr_fullScreen.Parent = pcr_picture;
        }

        public static Uri pictureWebSiteLink;
        private string wallpaperPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\arkalan.jpg";

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            pictureWebSiteLink = Wallhaven.GetRandomUrl(); //Random Resim Urlsini al

            DownloadImage(pictureWebSiteLink);
        }

        private void btn_wallpaper_Click(object sender, EventArgs e)
        {
            try
            {
                Wallpaper.Set(wallpaperPath);
                MessageBox.Show("Arkaplan Olarak Ayarlandı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("Arkaplan Ayarlanamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            frm_copy open = new frm_copy();
            open.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e) //Kaydetme işlemi
        {
            SaveFileDialog sfd_save = new SaveFileDialog();
            sfd_save.Filter = "*.jpg|*.jpg|*.png|*.png";
            sfd_save.FileName = pictureWebSiteLink.ToString().Substring(pictureWebSiteLink.AbsoluteUri.LastIndexOf("/") + 1);

            if (sfd_save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy(wallpaperPath, sfd_save.FileName, true);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pictureWebSiteLink = backList[backList.Count - 2];

            DownloadImage(pictureWebSiteLink);
        }

        private void pcr_desktop_Click(object sender, EventArgs e)
        {
            Shell32.Shell shell = new Shell32.Shell();
            shell.MinimizeAll();
        }

        private void pcr_fullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                tp_tools.SetToolTip(pcr_fullScreen, "Normal Ekran");
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                tp_tools.SetToolTip(pcr_fullScreen, "Tam Ekran");
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pcr_picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (pcr_picture.Image != null)
            {
                pcr_picture.DoDragDrop(new DataObject(DataFormats.FileDrop, new string[] { wallpaperPath }), DragDropEffects.Copy);
            }
        }

        private void pcr_picture_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Download(Uri url, string path) //İndirme işlemleri
        {
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications); //ssl desteği

            WebClient wb = new WebClient();
            wb.DownloadFileAsync(url, path); //alınan linki indirme ve kaydetme işlemi
            wb.DownloadProgressChanged += wb_DownloadProgressChanged;
            wb.DownloadFileCompleted += wb_DownloadFileCompleted;
        }

        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private List<Uri> backList = new List<Uri>();

        private void wb_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) //Dosya indirmesi tamamlandığında yapılacak işlemler
        {
            pcr_picture.ImageLocation = wallpaperPath;

            EnabledButtons(new Control[] { btn_wallpaper, btn_save, btn_link, btn_refresh }, true);

            backList.Add(pictureWebSiteLink);

            if (backList.Count > 1)
            {
                EnabledButtons(new Control[] { btn_back }, true);
            }
        }

        private void wb_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) //İndirme işlemini progressbara yansıt
        {
            pbar_download.Value = e.ProgressPercentage;
        }

        private void EnabledButtons(Control[] controls, bool enabled)
        {
            foreach (Control item in controls)
            {
                item.Enabled = enabled;
            }
        }

        private void WriteOnPicture(PictureBox pcr, string text)
        {
            Graphics write = pcr.CreateGraphics();

            using (Font myFont = new Font("Arial", 14))
            {
                write.DrawString(text, myFont, Brushes.Gray, new Point(0, 0));
            }
        }

        private void DownloadImage(Uri url)
        {
            if (Internet.IsConnected())
            {
                try
                {
                    WriteOnPicture(pcr_picture, "Lütfen Bekleyiniz...");

                    EnabledButtons(new Control[] { btn_wallpaper, btn_save, btn_link, btn_back }, false);

                    Uri downloadUrl = Wallhaven.GetDownloadUrl(url);

                    Download(downloadUrl, wallpaperPath);
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}