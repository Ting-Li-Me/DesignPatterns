namespace BridgePattern
{
    using System;
    using Models;
    using Interfaces;
    class Program
    {
        static void Main(string[] args)
        {
            Image img;
            IImageImp imp;

            string inputImg = string.Empty;
            string inputImp = string.Empty;

            Console.WriteLine("Enter Image Type:");
            inputImg = Console.ReadLine().ToLower();

            Console.WriteLine("Enter OS Type:");
            inputImp = Console.ReadLine().ToLower();

            while (inputImg != "end" && inputImp != "end")
            {
                if (inputImg == "jpg")
                {
                    img = new JPGImage();
                }
                else if (inputImg == "png")
                {
                    img = new PNGImage();
                }
                else if (inputImg == "bmp")
                {
                    img = new BMPImage();
                }
                else if (inputImg == "gif")
                {
                    img = new GIFImage();
                }
                else
                {
                    break;
                }

                if (inputImp == "windows")
                {
                    imp = new WIndowsImp();
                }
                else if (inputImp == "linux")
                {
                    imp = new LinuxImp();
                }
                else if (inputImp == "unix")
                {
                    imp = new UnixImp();
                }
                else
                {
                    break;
                }

                img.SetImageImp(imp);
                img.ParseFile("World Map");

               
                Console.WriteLine("Enter Image Type:");
                inputImg = Console.ReadLine().ToLower();

                Console.WriteLine("Enter OS Type:");
                inputImp = Console.ReadLine().ToLower();
            }

        }
    }
}
