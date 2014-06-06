using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample_CleanCodeBoundaries.FileLogger
{
    class FakeFileLogger : IFileLogger
    {

        public string FileName { get; set; }

        public void InitFile(string filename)
        {
            this.FileName = filename;
        }

        public void LogIntoFile(string message, MessageType type = MessageType.Info)
        {
            Console.WriteLine("will write \"{0}\" into the file {1} with type {2}", message, this.FileName, type);
        }


        public void CloseFile()
        {
            Console.WriteLine("Close the file");
        }
    }
}
