using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class DirectoryTraversal
{
    const string searchedDirectory = Console.ReadLine();
    const List<string> extensions = new List<string>();

    private static void FilesExtensions(DirectoryInfo directorySelected)
    {
        foreach (var file in directorySelected.GetFiles())
        {
            extensions.Add(file.Extension);
        }
    }
    static void Main()
    {
        DirectoryInfo directorySelected = new DirectoryInfo(searchedDirectory);
        FilesExtensions(directorySelected);

    }
}

