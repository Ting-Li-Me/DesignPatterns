namespace ChainOfResponsibilityPattern.Models
{
    using System;
    class Director:Approver
    {
        public Director(string name):base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest.Amount < 50000)
            {
                Console.WriteLine($"Director {name} has approved the Requese: {purchaseRequest.Amount}, {purchaseRequest.Purpose}");
            }
            else
            {
                successor.ProcessRequest(purchaseRequest);
            }
        }

    }
}
