namespace FacadePattern
{
    using Models;
    using System;

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
