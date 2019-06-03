using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbPSCBSLauncherGenerator
{
    public static class ClPbHelper
    {
        public static String FormatBytes(long lsize)
        {
            String s = "--";
            if (lsize > -1)
            {
                float f = lsize;
                String[] ss = new String[] { "B", "kB", "MB", "GB", "TB", "PB", "EB" };
                int i = 0;
                while (f > 1024)
                {
                    f = f / 1024;
                    i++;
                }
                if (i < ss.Length)
                {
                    s = f.ToString("0.00") + " " + ss[i];
                }
                else
                {
                    s = lsize.ToString() + " " + ss[0];
                }
            }
            return s;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
    }
}
