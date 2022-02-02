using EncryptionServiceDemo.Follow.Contracts;

namespace EncryptionServiceDemo.Follow
{
    public class EncryptionService
    {

        public void Encrypt(IReader reader, IWriter writer) 
        {
            // Read content
            byte[] content = reader.ReadAll(); 
            
            // encrypt
            byte[] encryptedContent = DoEncryption(content); 
            
            // write encrypted content
            writer.Write(encryptedContent);
        }

        private byte[] DoEncryption(byte[] content)
        {
            byte[] encryptedContent = null;
            // put here your encryption algorithm...
            return encryptedContent;
        }
    }
}
