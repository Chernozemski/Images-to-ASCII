using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToASCII.ImageActions
{
    class ImgActions
    {
        public static bool hasOpenedImage =false;
        public static Image OpenImage()
        {
            Image imgFile = null;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files (*.jpg, *jpeg, *png) | *jpg; *jpeg; *png";
            file.Title = "Open image";

            if (file.ShowDialog() == DialogResult.OK)
            {
                imgFile = Image.FromFile(file.FileName);
                GetImagePath = file.FileName;
                hasOpenedImage = true;
            }

            return imgFile;
        }
        public static void SaveImage(Image img)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "JPEG (*.jpg) | *jpeg";
            file.Title = "Save File";

            if (file.ShowDialog() == DialogResult.OK)
            {
                img.Save(file.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        public static void ToASCII(string filePath,string savePath)
        {
            Bitmap image = new Bitmap(filePath);
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(savePath))
            {
                for (int height = 0; height < image.Height; height++)
                {
                    for (int width = 0; width < image.Width; width++)
                    {
                        Color color = image.GetPixel(width, height);
                        double pixelBrightness = GetBrightness(color);
                        double index = pixelBrightness / 255 * (pixelsASCII.Length - 1);
                        char pixel = pixelsASCII[pixelsASCII.Length-(int)Math.Round(index) - 1];
                        
                        writer.Write(pixel);
                    }
                    writer.WriteLine();
                }
            }
        }
        private static double GetBrightness(Color color)
        {
            double brightness = Math.Sqrt
                (
                color.R * color.R * 0.241 +
                color.G * color.G * 0.691 +
                color.B * color.B * 0.068
                );

            return brightness;
        }
        private static string pixelsASCII = " .`-_':,R0";
        public static string GetImagePath;
    }
}
