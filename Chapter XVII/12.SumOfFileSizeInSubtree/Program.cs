using System;
using System.Collections.Generic;
using System.IO;

namespace _12.SumOfFileSizeInSubtree
{
    public class File
    {
        public string Name { get; private set; }
        public ulong Size { get; private set; }

        public File(string name, long size)
        {
            this.Name = name;
            this.Size = (ulong)size;
        }
    }

    public class Folder
    {
        public string Name { get; private set; }
        public List<Folder> SubFolders { get; private set; }
        public List<File> Files { get; private set; }

        public Folder(string name)
        {
            this.Files = new List<File>();
            this.SubFolders = new List<Folder>();
            this.Name = name;
        }

        public Folder(string name, params File[] files) : this(name)
        {
            foreach (var file in files)
            {
                this.Files.Add(file);
            }
        }

        public Folder(string name, params Folder[] subFolders) : this(name)
        {
            foreach (var subFolder in subFolders)
            {
                this.SubFolders.Add(subFolder);
            }
        }

        public Folder(string name, IEnumerable<File> files) : this(name)
        {
            this.Files.AddRange(files);
        }

        public Folder(string name, IEnumerable<Folder> folders): this(name)
        {
            this.SubFolders.AddRange(folders);
        }

        public Folder(string name, IEnumerable<File> files, IEnumerable<Folder> folders): this(name, files)
        {
            this.SubFolders.AddRange(folders);
        }

        public void AddSubFolder(Folder folder)
        {
            this.SubFolders.Add(folder);
        }

        public void AddFile(File file)
        {
            this.Files.Add(file);
        }
    }

    public class Tree
    {
        public Folder Root { get; set; }

        public Tree(Folder root)
        {
            this.Root = root;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string rootFolderPath = Console.ReadLine();

            if (!Directory.Exists(rootFolderPath))
            {
                throw new Exception();
            }

            Tree t = new Tree(new Folder(rootFolderPath));
            DirectoryInfo rootDirInfo = new DirectoryInfo(rootFolderPath);

            ConstructTree(rootDirInfo, t.Root);
            ulong totalFileSize = 0UL;
            GetTotalFileSizeInSubtree(t.Root, ref totalFileSize);
            Console.WriteLine("Total size of the directory: " + totalFileSize + " bytes");
        }   

        public static void ConstructTree(DirectoryInfo dirInfo, Folder folder)
        {
            var directories = dirInfo.GetDirectories();
            var files = dirInfo.GetFiles();

            foreach (var file in files)
            {
                File f = new File(file.FullName, file.Length);
                folder.AddFile(f);
            }

            foreach (var directory in directories)
            {
                Folder f = new Folder(directory.FullName);
                folder.AddSubFolder(f);

                ConstructTree(new DirectoryInfo(directory.FullName), f);
            }
        }

        public static void TraverseDepthFirst(Folder root)
        {
            Console.WriteLine(root.Name);

            foreach (var file in root.Files)
            {
                Console.WriteLine(file.Name);
            }

            foreach (var folder in root.SubFolders)
            {
                TraverseDepthFirst(folder);
            }
        }

        public static void GetTotalFileSizeInSubtree(Folder root, ref ulong totalSize)
        {
            foreach (var file in root.Files)
            {
                totalSize += file.Size;
            }

            foreach (var folder in root.SubFolders)
            {
                GetTotalFileSizeInSubtree(folder, ref totalSize);
            }
        }
    }
}
