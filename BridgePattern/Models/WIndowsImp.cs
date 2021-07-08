namespace BridgePattern.Models
{
    using Interfaces;
    using System;
    class WIndowsImp : IImageImp
    {
        public void DoPaint(Matrix m)
        {
            Console.WriteLine("Displaying images on Windows platform");
        }
    }
}
