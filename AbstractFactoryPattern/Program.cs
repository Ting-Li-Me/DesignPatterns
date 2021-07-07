using System;

namespace AbstractFactoryPattern
{
    using System;
    using Interfaces;
    using Models;
    using Factories;
    class Program
    {
        static void Main(string[] args)
        {
            ISkinFactory factory;
            IButton bt;
            ITextField tf;
            IComboBox cb;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var type = input.ToLower();

                if (type == "spring")
                {
                    factory = new SpringSkinFactory();
                    bt = factory.CreateButton();
                    tf = factory.CreateTextField();
                    cb = factory.CreateComboBox();

                    bt.Display();
                    tf.Display();
                    cb.Display();
                }
                else if (type == "summer")
                {
                    factory = new SummerSkinFactory();
                    bt = factory.CreateButton();
                    tf = factory.CreateTextField();
                    cb = factory.CreateComboBox();

                    bt.Display();
                    tf.Display();
                    cb.Display();
                }
            }
          
        }

    }
}
