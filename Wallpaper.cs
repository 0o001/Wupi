using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace wupi
{
    class Wallpaper
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);
        public static void Set(String path) //Arka planı ayarlamak için
        {
            SystemParametersInfo(0x14, 0, path, 0x01 | 0x02);
        }

        public static string GetPath()
        {
            string pathWallpaper = null;

            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false);

            if (regKey != null)
            {
                pathWallpaper = regKey.GetValue("WallPaper").ToString();
                regKey.Close();
            }

            return pathWallpaper;
        }
    }
}
