using System;
using System.IO;
using System.Text;


namespace ImageProcessor
{


    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Images";
            string path  = @"c:\Users\george\source\repos\ImageProcessor\" + fileName;
            string sPath = @"c:\Users\george\source\repos\ImageProcessor\Edited photos";
            string pathT = path + @"\readMe.txt";
            var    watch = new System.Diagnostics.Stopwatch();
            
            watch.Start();

            try
            {
                System.IO.Directory.CreateDirectory(path);

                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(pathT))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is the folder where" +
                    " my pictures will be loaded into for use. \n Add photos from other" +
                    " directories using program.cs or copy directly to this folder.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
                // Open the file stream and read it back.
                using (StreamReader sr = File.OpenText(pathT))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                //if the paths exist calls classes to copy and water mark then
                //send file to destination folder.
                if (Directory.Exists(sPath))
                {
                    if (Directory.Exists(path))
                    {
                       Console.WriteLine("Image(s) has been taking hostage.");
                       ImageGraber.Graber(sPath, path);
                    }
                    else
                    {
                    Console.WriteLine("2: Didn't get any images though. :(");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            watch.Stop();

            Console.WriteLine("\n" + "\n" + $"Execution Time: {watch.ElapsedMilliseconds} ms" +"\n"+ "If there is directories above it worked. " +
            "Good for you...Or is it. IF not well try again. HA HA HA..." + "\n" + 
            "Press A key I dare you.");
            //Console.ReadKey();
        }
    }
}