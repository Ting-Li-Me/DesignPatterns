namespace BridgePattern.Models
{
    using Interfaces;
    using System;
    class LinuxImp:IImageImp
    {
        public void DoPaint(Matrix m)
        {
            Console.WriteLine("Displaying images on Linux platform");
        }
    }
}
