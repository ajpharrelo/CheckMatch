namespace SHA256_Checksum
{
    public class CheckFile
    {
        public string FilePath { get; set; }
        private string? Checksum;

        public CheckFile(string filePath)
        {
            FilePath = filePath;
        }

        public void GenerateChecksum()
        {

        }

        public string GetFileChecksum()
        {
            if (Checksum != null)
                return Checksum;

            return "";
        }
    }
}