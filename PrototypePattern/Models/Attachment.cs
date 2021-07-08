using System;

namespace PrototypePattern.Models
{
    class Attachment
    {
        public string Name { get; set; }
        public void Download()
        {
            Console.WriteLine($"Download attachment {Name}");
        }
    }
}
