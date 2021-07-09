using System;

namespace CompositPattern
{
    using System;
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            AbstractFile file1, file2, file3, file4, file5, folder1, folder2, folder3, folder4;

            folder1 = new Folder("my doc");
            folder2 = new Folder("my images");
            folder3 = new Folder("my texts");
            folder4 = new Folder("my videos");

            file1 = new ImageFile("angel.jpg");
            file2 = new ImageFile("hero.gif");
            file3 = new TextFile("english_book.txt");
            file4 = new TextFile("chinese_book.doc");
            file5 = new VideoFile("movie.mp4");

            folder2.Add(file1);
            folder2.Add(file2);
            folder3.Add(file3);
            folder3.Add(file4);
            folder4.Add(file5);
            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            folder1.KillVirus();
            Console.ReadKey();
        }
    }
}
