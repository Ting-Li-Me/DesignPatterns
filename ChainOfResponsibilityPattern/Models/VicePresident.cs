namespace ChainOfResponsibilityPattern.Models
{
    using System;
    class VicePresident: Approver
    {
        public VicePresident(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest.Amount < 100000)
            {
                Console.WriteLine($"Vice President {name} has approved the Requese: {purchaseRequest.Amount}, {purchaseRequest.Purpose}");
            }
            else
            {
                successor.ProcessRequest(purchaseRequest);
            }
        }
    }
}
