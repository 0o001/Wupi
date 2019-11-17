using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wupi
{
    class ImageBlur
    {
        public static Bitmap Make(Image img)
        {
            Bitmap picture = new Bitmap(img);

            for (int width = 0; width < picture.Width; width++)
            {
                for (int height = 0; height < picture.Height; height++)
                {
                    Color color = picture.GetPixel(width, height);
                    Color newColor = Color.FromArgb(80, color);
                    picture.SetPixel(width, height, newColor);
                }
            }

            return picture;
        }
    }
}
