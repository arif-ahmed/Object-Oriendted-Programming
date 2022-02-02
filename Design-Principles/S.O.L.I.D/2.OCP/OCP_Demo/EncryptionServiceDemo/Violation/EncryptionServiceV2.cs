
using System.Text;

namespace EncryptionServiceDemo.Violation
{
    public class EncryptionServiceV2
    {
        public void Encrypt(ContentSource source, ContentTarget target)
        {
            // Read content
            byte[] content = null;  
            
            switch (source) 
            { 
                case ContentSource.File: 
                    content = GetFromFile(); 
                    break; 
                case ContentSource.Database: 
                    content = GetFromDatabase(); 
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
                case ContentTarget.WebService: 
                    WriteToWebService(encryptedContent); 
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
            Console.WriteLine("Simulating reading content from a file...");
            // Dummy file content as bytes
            return Encoding.UTF8.GetBytes("File content");
        }

        private byte[] GetFromDatabase()
        {
            Console.WriteLine("Simulating fetching content from a database...");
            // Dummy database content as bytes
            return Encoding.UTF8.GetBytes("Database content");
        }

        private void WriteToFile(byte[] encryptedContent)
        {
            Console.WriteLine("Simulating writing encrypted content to a file...");
            // Simulate writing bytes to a file
            File.WriteAllBytes("encrypted_file.txt", encryptedContent);
            Console.WriteLine("Encrypted content written to 'encrypted_file.txt'.");
        }

        private void WriteToWebService(byte[] encryptedContent)
        {
            Console.WriteLine("Simulating sending encrypted content to a web service...");
            using (HttpClient client = new HttpClient())
            {
                // Dummy web service URL
                string url = "https://example.com/encrypt";
                HttpContent httpContent = new ByteArrayContent(encryptedContent);
                HttpResponseMessage response = client.PostAsync(url, httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Encrypted content successfully sent to the web service.");
                }
                else
                {
                    Console.WriteLine("Failed to send encrypted content to the web service.");
                }
            }
        }
    }
}
