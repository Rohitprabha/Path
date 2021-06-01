using System;
using System.IO;

namespace Path_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmpPath = @"C:\Users\Rohit Dasari\source\repos\Path\bin\Debug\netcoreapp3.1\text.txt";
            string fileExtension = Path.GetExtension(tmpPath);
            string filename = Path.GetFileName(tmpPath);
            string filenameWithoutExtension = Path.GetFileNameWithoutExtension(tmpPath);
            string rootPath = Path.GetPathRoot(tmpPath);
            string directory = Path.GetDirectoryName(tmpPath);
            string fullPath = Path.GetFullPath(tmpPath);

            Console.WriteLine(fileExtension);
            Console.WriteLine(filename);
            Console.WriteLine(filenameWithoutExtension);
            Console.WriteLine(rootPath);
            Console.WriteLine(directory);
            Console.WriteLine(fullPath);

        }
    }
}
