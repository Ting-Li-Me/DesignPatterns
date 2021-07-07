namespace BuilderPattern
{
    using System;
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            ActorBuilder ab;
            string input = string.Empty;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                var type = input;

                if (type == "hero")
                {
                    ab = new HeroBuilder();
                }
                else if (type == "angel")
                {
                    ab = new AngelBuilder();
                }
                else if (type == "evil")
                {
                    ab = new DeviBuilder();
                }
                else { return; }


                ActorController ac = new ActorController();
                Actor actor;

                actor = ac.Construct(ab);

                Console.WriteLine($"{ actor.Type }");
                Console.WriteLine($"{ actor.Sex }");
                Console.WriteLine($"{ actor.Face }");
                Console.WriteLine($"{ actor.Costume }");
                Console.WriteLine($"{ actor.Hairstyle }");
            }

        }
    }
}
