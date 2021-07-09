namespace CompositPattern.Models
{
    using System;
    class VideoFile:AbstractFile
    {
        private string name;
        public VideoFile(string name)
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
            Console.WriteLine($"--- Kill Virus for video file {name}");
        }
    }
}
