using FileAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample_CleanCodeBoundaries.FileLogger
{
    class FileLoggerAdapter : IFileLogger
    {
        private FileWriter fileWriter;

        public void InitFile(string filename)
        {
            fileWriter = new FileWriter(filename);
        }

        public void LogIntoFile(string message, MessageType type = MessageType.Info)
        {
            string toWrite = String.Format("{0}: {1}", type, message);
            fileWriter.AppendToFile(toWrite);
        }


        public void CloseFile()
        {
            fileWriter.CloseFile();
        }
    }
}
