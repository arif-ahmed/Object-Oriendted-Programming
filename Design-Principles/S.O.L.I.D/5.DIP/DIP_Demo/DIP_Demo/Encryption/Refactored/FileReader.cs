using System;


namespace DIP_Demo.Encryption.Refactored
{
    using Contracts;
    using System.IO;

    public class FileReader : ISource
    {
        public string SourceFileName { get; set; }
        public byte[] ReadFromSource()
        {
            byte[] content;
            using (var fs = new FileStream(SourceFileName, FileMode.Open, FileAccess.Read))
            {
                content = new byte[fs.Length];
                fs.Read(content, 0, content.Length);
            }

            return content;
        }
    }
}
