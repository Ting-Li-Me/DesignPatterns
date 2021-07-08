

namespace PrototypePattern
{
    using System;
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            WeeklyLog previousLog, newLog;
            previousLog = new WeeklyLog();
            Attachment attachment = new Attachment();
            previousLog.Attachment = attachment;

            newLog = previousLog.ShollowClone();

            Console.WriteLine($"Logs are same?: {newLog == previousLog}");
            Console.WriteLine($"Attachment are same?:{newLog.Attachment == previousLog.Attachment}");

            
            newLog = previousLog.DeepClone();
            

            Console.WriteLine($"Logs are same?: {newLog == previousLog}");
            Console.WriteLine($"Attachment are same?:{newLog.Attachment == previousLog.Attachment}");

            Console.ReadLine();

        }
    }
}
