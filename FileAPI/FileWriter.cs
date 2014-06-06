using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPI
{
    public class FileWriter
    {

        private System.IO.StreamWriter file;

        private string _filePath;
        public string FilePath { get { return _filePath; } }

        public FileWriter(string filename)
        {
            this._filePath = "c:\\" + filename;
            file = new System.IO.StreamWriter(this._filePath, append: true);
        }

        public void AppendToFile(string message) {
            // Write the string to a file.
            file.WriteLine(message);
        }

        public void CloseFile() {
            file.Close();
        }

        public string ReadAllText() {
            return System.IO.File.ReadAllText(this._filePath);
        }

        public static void DeleteFile(string filename) 
        {
            File.Delete("c:\\" + filename);
        }

    }
}
