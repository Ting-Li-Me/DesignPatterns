namespace ChainOfResponsibilityPattern
{
    using Models;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Approver director, vp, president, congress;

            director = new Director("directorName");
            vp = new VicePresident("vpName");
            president = new President("presientName");
            congress = new Congress("congressName");

            director.SetSuccessor(vp);
            vp.SetSuccessor(president);
            president.SetSuccessor(congress);

            PurchaseRequest pr1 = new PurchaseRequest(45000, 10001, "buy a pen");
            director.ProcessRequest(pr1);

            PurchaseRequest pr2 = new PurchaseRequest(60000, 10002, "buy a book");
            director.ProcessRequest(pr2);

            PurchaseRequest pr3 = new PurchaseRequest(160000, 10003, "buy a car");
            director.ProcessRequest(pr3);

            PurchaseRequest pr4 = new PurchaseRequest(800000, 10003, "buy a boat");
            director.ProcessRequest(pr4);

            Console.ReadLine();
        }
    }
}
