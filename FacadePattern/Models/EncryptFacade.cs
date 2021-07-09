namespace FacadePattern.Models
{
    class EncryptFacade
    {
        private FileReader reader;
        private CipherMachine cipher;
        private FileWriter writer;

        public EncryptFacade()
        {
            reader = new FileReader();
            cipher = new CipherMachine();
            writer = new FileWriter();

        }

        public void FileEncrypt(string filenameSrc, string filenameDes)
        {
            string plainStr = reader.Read(filenameSrc);
            string encryptedStr = cipher.Encrypt(plainStr);
            writer.Write(encryptedStr, filenameDes);
        }

    }
}
