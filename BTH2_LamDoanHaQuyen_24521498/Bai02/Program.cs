using System;
using System.IO;
using System.Text;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIRECTORY LISTING PROGRAM (DIR SIMULATION)");
            Console.WriteLine("============================================\n");

            Console.Write("Enter directory path: ");
            string path = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                Console.WriteLine("The specified path does not exist!");
                return;
            }

            Console.WriteLine($"\nDirectory of {path}\n");
            Console.WriteLine("=====================================================");

            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                long totalBytes = 0;

                const int typeWidth = 15;
                const int nameWidth = -40;

                foreach (string dir in directories)
                {
                    DirectoryInfo dInfo = new DirectoryInfo(dir);
                    Console.WriteLine($"{dInfo.LastWriteTime:dd/MM/yyyy hh:mm tt} {"<DIR>", 10} {dInfo.Name}");
                }

                foreach (string file in files)
                {
                    FileInfo fInfo = new FileInfo(file);
                    totalBytes += fInfo.Length;
                    Console.WriteLine($"{fInfo.LastWriteTime:dd/MM/yyyy hh:mm tt} {fInfo.Length,10:N0} {fInfo.Name}");
                }

                Console.WriteLine("\nSummary:");
                DriveInfo drive = new DriveInfo(Path.GetPathRoot(path));
                Console.WriteLine($"   {files.Length,5} files        {totalBytes,15:N0} bytes");
                Console.WriteLine($"   {directories.Length,5} directories  {drive.AvailableFreeSpace,15:N0} bytes free\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
