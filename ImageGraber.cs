using System;
using System.Threading.Tasks;

namespace ImageProcessor
{
    public static class ImageGraber
    {
        public static void  Graber(string sourcePath, string destinationPath)
        {
            string[] files = System.IO.Directory.GetFiles(sourcePath);
            Console.WriteLine("Hostages are being moved.");
            Parallel.ForEach(files, file =>
             {
                // Use static Path methods to extract only the file name from the path.
                 var fileName = System.IO.Path.GetFileName(file);
                 var destFile = System.IO.Path.Combine(destinationPath, fileName);
                 WaterM.Marker(sourcePath + @"\" + fileName, destFile);
             });
            Console.WriteLine("Hostages have been freed.");
        }
    }
}