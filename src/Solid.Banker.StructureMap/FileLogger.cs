using System;
using System.IO;
using Solid.Banker.Logging;

namespace Solid.Banker.StructureMap
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void Log(string message, params object[] param)
        {
            using(var streamWriter = File.AppendText(_path))
            {
                var originalMessage = string.Format(message, param);
                streamWriter.WriteLine("{0}: {1}", DateTime.Now, originalMessage);
            }
        }
    }
}