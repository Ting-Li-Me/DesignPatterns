namespace BridgePattern.Models
{
    using System;
    class JPGImage : Image
    {
        public override void ParseFile(string Filename)
        {
            Matrix m = new Matrix();
            imp.DoPaint(m);
            Console.WriteLine($"{Filename} is JPG");
        }
    }
}
