using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample_CleanCodeBoundaries.FileLogger
{
    public enum MessageType { 
        Info,
        Warning,
        Error
    }

    interface IFileLogger
    {
        void InitFile(string filename);
        void CloseFile();
        void LogIntoFile(string message, MessageType type = MessageType.Info);
    }
}
