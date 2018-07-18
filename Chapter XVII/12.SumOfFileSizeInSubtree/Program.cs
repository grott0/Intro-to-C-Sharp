using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SumOfFileSizeInSubtree
{
    public class File
    {
        public string Name { get; private set; }
        public int Size { get; private set; }
    }

    public class Folder
    {
        public string Name { get; private set; }
        public List<Folder> SubFolders { get; private set; }
        public List<File> Files { private get; set; }

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

        public void AddFolder(Folder folder)
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
            DirectoryInfo rootFolder = new DirectoryInfo(rootFolderPath);
            

        }

        public static void TraverseDepthFirst()
        {

        }
    }
}
