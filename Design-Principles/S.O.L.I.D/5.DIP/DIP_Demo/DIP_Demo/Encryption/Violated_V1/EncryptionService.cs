namespace DIP_Demo.Encryption.Violated_V1
{
    using System.IO;
    public class EncryptionService
    {
        public void Encrypt(string sourceFileName, string targetFileName)
        {
            // Read content
            byte[] content;
            using (var fs = new FileStream(sourceFileName, FileMode.Open, FileAccess.Read))
            {
                content = new byte[fs.Length];
                fs.Read(content, 0, content.Length);
            }

            // encrypt
            byte[] encryptedContent = DoEncryption(content);

            // write encrypted content
            using (var fs = new FileStream(targetFileName, FileMode.CreateNew, FileAccess.ReadWrite))
            {
                fs.Write(encryptedContent, 0, encryptedContent.Length);
            }
        }

        private byte[] DoEncryption(byte[] content)
        {
            byte[] encryptedContent = null;
            // put here your encryption algorithm...
            return encryptedContent;
        }
    }       
}
