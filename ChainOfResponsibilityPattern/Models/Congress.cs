namespace ChainOfResponsibilityPattern.Models
{
    using System;
    class Congress:Approver
    {
        public Congress(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest purchaseRequest)
        {
            Console.WriteLine($"Congress {name} has approved the Requese: {purchaseRequest.Amount}, {purchaseRequest.Purpose}");
        }
    }
}
