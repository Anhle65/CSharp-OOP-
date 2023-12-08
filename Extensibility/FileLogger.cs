using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "Error");
        }
        public void LogInfo (string message)
        {
            Log(message, "Info");
        }

        // the Log() method using to not repeated the same code for 2 diff LogError and LogInfo, which do the same thing
        private void Log(string message, string messageType)
        {
            // If there is an exception raised when complied, "using block" will make sure to close the file (calling Dispose method automatically instead of manually)
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType}: " + message);
            }
        }
    }
}
