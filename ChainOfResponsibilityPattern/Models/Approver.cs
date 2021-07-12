namespace ChainOfResponsibilityPattern.Models
{
    abstract class Approver
    {
        protected Approver successor;
        protected string name;

        public Approver(string name)
        {
            this.name = name;
        }

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(PurchaseRequest purchaseRequest);

    }
}
