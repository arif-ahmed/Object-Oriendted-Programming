namespace DIP_Demo.Encryption
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Encryption;
    public class EncryptionDemo
    {
        public static void ViolatedV1_Demo()
        {
            Violated_V1.EncryptionService encryptionService = new Violated_V1.EncryptionService();

            string sourceFileName = "source.txt";
            string targetFileName = "target.txt";

            encryptionService.Encrypt(sourceFileName, targetFileName);
        }
        public static void ViolatedV2_Demo()
        {
            Violated_V2.EncryptionService encryptionService = new Violated_V2.EncryptionService();

            encryptionService.SourceFileName = "source.txt";
            encryptionService.TargetFileName = "target.txt";

            encryptionService.Encrypt(Violated_V2.ContentSource.File, Violated_V2.ContentTarget.Database);
        }

        public static void Refactored_Demo()
        {
            Refactored.Contracts.ISource source = new Refactored.FileReader();
            ((Refactored.FileReader)source).SourceFileName = "source.txt";

            Refactored.Contracts.ITarget target = new Refactored.DatabaseWriter();

            Refactored.EncryptionService encryptionService = new Refactored.EncryptionService(source, target);

            encryptionService.Encrypt();
        }
    }
}
