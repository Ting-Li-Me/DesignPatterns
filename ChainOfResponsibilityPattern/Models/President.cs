namespace ChainOfResponsibilityPattern.Models
{
    using System;
    class President:Approver
    {
        public President(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest.Amount < 300000)
            {
                Console.WriteLine($"President {name} has approved the Requese: {purchaseRequest.Amount}, {purchaseRequest.Purpose}");
            }
            else
            {
                successor.ProcessRequest(purchaseRequest);
            }
        }
    }
}
