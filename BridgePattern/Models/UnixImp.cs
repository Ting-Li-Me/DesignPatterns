namespace BridgePattern.Models
{
    using Interfaces;
    using System;
    class UnixImp : IImageImp
    {
        public void DoPaint(Matrix m)
        {
            Console.WriteLine("Displaying images on Unix platform");
        }
    }
}
