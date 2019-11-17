using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wupi
{
    public partial class frm_copy : Form
    {
       
        public frm_copy()
        {
            InitializeComponent();

            txt_copy.Text = frm_wallpaper.pictureWebSiteLink.ToString();
            txt_copy.Select();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
           Clipboard.SetText(frm_wallpaper.pictureWebSiteLink.ToString());
           this.Close();
        }
    }
}
