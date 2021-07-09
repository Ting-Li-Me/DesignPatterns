using System;

namespace FacadePattern
{
    using System;
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            EncryptFacade ef = new EncryptFacade();
            ef.FileEncrypt("src.txt", "des.txt");

            Console.ReadLine();
        }
    }
}
