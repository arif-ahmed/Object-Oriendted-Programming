namespace DIP_Demo.Encryption.Refactored
{
    using Contracts;
    public class EncryptionService
    {
        private byte[] content;
        private ISource _source;
        private ITarget _target;

        public EncryptionService(ISource source, ITarget target)
        {
            _source = source;
            _target = target;
        }

        public void Encrypt()
        {
            // Read content
            content = _source.ReadFromSource();
            // encrypt
            byte[] encryptedContent = DoEncryption(content);
            // write encrypted content
            _target.WriteToTarget(encryptedContent);
        }
        private byte[] DoEncryption(byte[] content)
        {
            byte[] encryptedContent = null;
            // put here your encryption algorithm...
            return encryptedContent;
        }
    }
}
