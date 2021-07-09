namespace FacadePattern.Models
{
    using System;
    class FileWriter
    {
        public void Write(string encryptedStr, string filename)
        {
            Console.WriteLine($"save encrypted text to {filename} ");
        }
    }
}
