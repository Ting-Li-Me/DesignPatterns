namespace CompositPattern.Models
{
    using System;
    class ImageFile : AbstractFile
    {
        private string name;
        public ImageFile(string name)
        {
            this.name = name;
        }
        public override void Add(AbstractFile file)
        {
            Console.WriteLine("Not supported");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("Not supported");
        }
        public override AbstractFile GetChild(int i)
        {
            Console.WriteLine("Not supported");
            return null;
        }

        public override void KillVirus()
        {
            Console.WriteLine($"--- Kill Virus for image file {name}");
        }

        
    }
}
