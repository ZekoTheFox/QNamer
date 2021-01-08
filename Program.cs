using System;
using System.IO;

namespace QNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] currentFiles = Directory.GetFiles(currentDirectory);

            for (int f = 0; f < currentFiles.Length; f++)
            {
                if (!currentFiles[f].Contains(System.AppDomain.CurrentDomain.FriendlyName))
                    try
                    {
                        Console.WriteLine($"Attempting to rename [{currentFiles[f]}]...");

                        //File.Move(currentFiles[f], Guid.NewGuid().ToString() + ".mp4");
                        File.Move(currentFiles[f], Guid.NewGuid().ToString() + $".{currentFiles[f].Split('.')[currentFiles[f].Split('.').Length - 1]}");

                        Console.WriteLine("Successfully renamed the file");

                    } catch (Exception)
                    {
                        Console.WriteLine($"The file couldn't be renamed");
                    }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
