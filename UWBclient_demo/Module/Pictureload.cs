using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace UWBclient_demo
{ 
    class Pictureload
    {

        public static System.Drawing.Bitmap GetResourceBitmap(string strImageName)
        {
            object obj = Properties.Resources.ResourceManager.GetObject(strImageName, Properties.Resources.Culture);
            return ((System.Drawing.Bitmap)(obj));
        }

        public static System.Drawing.Image GetResourceImage(string strImageName)
        {
            object obj = Properties.Resources.ResourceManager.GetObject(strImageName, Properties.Resources.Culture);
            return ((System.Drawing.Image)(obj));
        }

        public static unsafe Region GetRegion(Bitmap bckImage)
        {
            GraphicsPath path = new GraphicsPath();
            int w = bckImage.Width;
            int h = bckImage.Height;
            BitmapData bckdata = null;
            try
            {
                bckdata = bckImage.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                uint* bckInt = (uint*)bckdata.Scan0;
                for (int j = 0; j < h; j++)
                {
                    for (int i = 0; i < w; i++)
                    {
                        if ((*bckInt & 0xff000000) != 0)
                        {
                            path.AddRectangle(new Rectangle(i, j, 1, 1));
                        }
                        bckInt++;
                    }
                }
                bckImage.UnlockBits(bckdata); bckdata = null;
            }
            catch
            {
                if (bckdata != null)
                {
                    bckImage.UnlockBits(bckdata);
                    bckdata = null;
                }
            }
            Region region = new System.Drawing.Region(path);
            path.Dispose(); path = null;
            return region;
        }


    }
}

