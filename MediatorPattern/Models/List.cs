namespace MediatorPattern.Models
{
    using System;
    class List:Component
    {
        public override void Update()
        {
            Console.WriteLine("List added an item: Jack");
        }
        public void Select()
        {
            Console.WriteLine("an item selected from the list: Angel");
        }
        
    }
}
