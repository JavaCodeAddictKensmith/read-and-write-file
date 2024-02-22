using ReadWrite.Core.Interfaces;
using ReadWrite.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ReadWrite.Core.Implementation
{
    public class WriteToTextFile : IWriteToTextFile
    {
        public string ReadTextFile()
        {
            //string path = @"/Users/hp/Desktop/NotImportant/ReadWriteTo FileAPI/ReadWriteTo FileAPI/FolderAccess.txt";
            string relativepath = Path.Combine(Environment.CurrentDirectory, "FolderAccess.txt"); // Relative path
             return File.ReadAllText(relativepath);
        }

        public string WriteToText(string[] employee)
        {
            string message = string.Empty;
           // string path = @"/Users/hp/Desktop/NotImportant/ReadWriteTo FileAPI/ReadWriteTo FileAPI/FolderAccess.txt"; // Absolute path
            string currentPath = Path.Combine(Environment.CurrentDirectory, "FolderAccess.txt"); // Relative path
            File.AppendAllLines(currentPath, employee);
            if(employee != null)
            {
                message = "Added A Text";
            }
            return message;
        }

        string IWriteToTextFile.DeleteFromFile()
        {
            string message = string.Empty;
            string path = Path.Combine(Environment.CurrentDirectory, "FolderAccess.txt");
            File.Delete(path);
            if(path != null)
            {
                message = "Deleted";
            }
            return message;

        }
    }
}
