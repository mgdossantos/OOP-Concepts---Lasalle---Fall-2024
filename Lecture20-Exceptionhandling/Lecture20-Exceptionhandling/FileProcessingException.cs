using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture20_Exceptionhandling
{
    [Serializable]
    public class FileProcessingException : Exception
    {
        public FileProcessingException(string message) : base(message) { }
    }

    public class FileReadException : FileProcessingException
    {
        public FileReadException(string message) : base(message) { }
    }

    public class FileWriteException : FileProcessingException
    {
        public FileWriteException(string message) : base(message) { }
    }
}
