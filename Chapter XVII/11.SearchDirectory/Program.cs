using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SearchDirectory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Root directory path: ");
            string rootDirPath = Console.ReadLine();
            DirectoryInfo rootDir = new DirectoryInfo(rootDirPath);
            TraverseRootDir(rootDir);
        }

        public static void TraverseRootDir(DirectoryInfo rootDir)
        {
            var directories = rootDir.GetDirectories();
            var files = rootDir.GetFiles();

            foreach (var file in files.Where(x => x.Name.EndsWith(".exe")))
            {
                Console.WriteLine(file.FullName);
            }

            foreach (var directory in directories)
            {
                TraverseRootDir(directory);
            }
        }
    }
}
