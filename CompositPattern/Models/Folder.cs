namespace CompositPattern.Models
{
    using System;
    using System.Collections.Generic;
    class Folder:AbstractFile
    {
        private IList<AbstractFile> fileList = new List<AbstractFile>();
        private string name;

        public Folder(string name)
        {
            this.name = name;
        }
        public override void Add(AbstractFile file)
        {
            fileList.Add(file);
        }

        public override void Remove(AbstractFile file)
        {
            fileList.Remove(file);
        }

        public override AbstractFile GetChild(int i)
        {   
            return (AbstractFile)fileList[i];
        }

        public override void KillVirus()
        {
            Console.WriteLine($"--- Kill Virus for folder {name}");

            foreach (AbstractFile file in fileList)
            {
                file.KillVirus();
            }
        }


    }
}
