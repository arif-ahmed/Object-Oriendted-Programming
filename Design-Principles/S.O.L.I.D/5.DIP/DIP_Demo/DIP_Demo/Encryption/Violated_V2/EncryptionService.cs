namespace DIP_Demo.Encryption.Violated_V2
{
    using System.IO;
    public class EncryptionService
    {
        // Read content
        byte[] content;
        public string SourceFileName { get; set; }
        public string TargetFileName { get; set; }
        public void Encrypt(ContentSource source, ContentTarget target)
        {
            // Read content
            switch (source)
            {
                case ContentSource.File:
                    content = GetFromFile();
                    break;

                case ContentSource.Database:
                    content = GetFromDatabase();
                    break;

                default:
                    break;
            }

            // encrypt
            byte[] encryptedContent = DoEncryption(content);

            // write encrypted content
            switch (target)
            {
                case ContentTarget.File:
                    WriteToFile(encryptedContent);
                    break;
                case ContentTarget.Database:
                    WriteToDatabase(encryptedContent);
                    break;
                default:
                    break;
            }
        }

        private byte[] DoEncryption(byte[] content)
        {
            byte[] encryptedContent = null;
            // put here your encryption algorithm...
            return encryptedContent;
        }

        private byte[] GetFromFile()
        {
            using (var fs = new FileStream(SourceFileName, FileMode.Open, FileAccess.Read))
            {
                content = new byte[fs.Length];
                fs.Read(content, 0, content.Length);
            }

            return content;
        }

        private byte[] GetFromDatabase()
        {
            return new byte[100];
        }

        private void WriteToFile(byte[] content)
        {
            using (var fs = new FileStream(TargetFileName, FileMode.CreateNew, FileAccess.ReadWrite))
            {
                fs.Write(content, 0, content.Length);
            }
        }

        private void WriteToDatabase(byte[] content)
        {

        }
    }       
}
