using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SHA256_Checksum
{
    public class CheckFile
    {
        public string FilePath { get; set; }
        public string Checksum { get; private set; }

        public CheckFile(string filePath)
        {
            FilePath = filePath;
            Checksum = GenerateChecksum();
        }

        private string GenerateChecksum()
        {
            if(File.Exists(FilePath))
            {
                using(SHA256 sha = SHA256.Create())
                {
                    byte[] bytes = sha.ComputeHash(File.ReadAllBytes(FilePath));
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < bytes.Length; i++)
                    {
                        sb.Append($"{bytes[i]:x2}");
                    }

                    return sb.ToString();
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}