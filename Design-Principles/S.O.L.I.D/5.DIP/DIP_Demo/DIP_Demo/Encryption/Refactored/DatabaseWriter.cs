namespace DIP_Demo.Encryption.Refactored
{
    using Contracts;
    using System.IO;

    public class DatabaseWriter : ITarget
    {
        public string TargetFileName { get; set; }
        public void WriteToTarget(byte[] content)
        {
            using (var fs = new FileStream(TargetFileName, FileMode.CreateNew, FileAccess.ReadWrite))
            {
                fs.Write(content, 0, content.Length);
            }
        }
    }
}
