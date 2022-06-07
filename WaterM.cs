using System;
using System.Drawing;

namespace ImageProcessor
{
    public static class WaterM
    {
        public static void Marker(string markMe, string dPath)
        {
            Image bitmap = Bitmap.FromFile(markMe);
            Graphics graphicsImage = Graphics.FromImage(bitmap);
            StringFormat stringformat1 = new StringFormat();
            stringformat1.Alignment = StringAlignment.Near;
            Color StringColor = ColorTranslator.FromHtml("#996666");
            string Str_TextOnImage = "New Moon Adventures";
            graphicsImage.DrawString(Str_TextOnImage, new Font("arial", 65, FontStyle.Regular),
            new SolidBrush(StringColor), new Point(0, 0), stringformat1);
            Console.WriteLine(dPath);
            bitmap.Save(dPath);
            bitmap.Dispose();
        }
    }
}