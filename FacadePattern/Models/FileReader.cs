namespace FacadePattern.Models
{
    using System;
    class FileReader
    {
        public string Read(string filenameSrc)
        {
            Console.WriteLine("read file, get plain text");
            return "plain file text";
        }
    }
}
