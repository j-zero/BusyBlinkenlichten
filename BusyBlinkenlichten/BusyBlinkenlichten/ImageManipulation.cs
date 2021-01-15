using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace BusyBlinkenlichten
{
    class ImageManipulation
    {
        public static Image ReplaceColor(Image original, Color oldColor, Color newColor)
        {
            Bitmap bmp = new Bitmap(original);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = oldColor;
                colorMap[0].NewColor = newColor;
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
            return bmp;
        }

        public static Image MatrixBlend(Image image1, Image image2, float alpha)
        {
            Bitmap bitmap1 = new Bitmap(image1);
            Bitmap bitmap2 = new Bitmap(image2);

            Bitmap returnImage = new Bitmap(image1);

            ColorMatrix matrix = new ColorMatrix(new float[][]{
                new float[] {1F, 0, 0, 0, 0},
                new float[] {0, 1F, 0, 0, 0},
                new float[] {0, 0, 1F, 0, 0},
                new float[] {0, 0, 0, alpha, 0},
                new float[] {0, 0, 0, 0, 1F}});

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(matrix);

            using (Graphics g = Graphics.FromImage(returnImage))
            {
                g.CompositingMode = CompositingMode.SourceOver;
                g.CompositingQuality = CompositingQuality.HighQuality;

                g.DrawImage(bitmap2,
                    new Rectangle(0, 0, bitmap1.Width, bitmap1.Height),
                    0,
                    0,
                    image2.Width,
                    image2.Height,
                    GraphicsUnit.Pixel,
                    imageAttributes);
            }
            return returnImage;

        }
    }
}
