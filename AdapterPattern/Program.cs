namespace AdapterPattern
{
    using System;
    using Interfaces;
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            IScoreOperation scoreOperation = new OperationAdapter();

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;
            int input=100;

            Console.Write("Scores Sorting Result:");
            result = scoreOperation.Sort(scores);

            foreach(int i in result)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine();

            while (input != 0)
            {
                Console.Write("Please input the number you are searching for:");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                score = scoreOperation.Search(scores, input);

                if (score != -1)
                {
                    Console.WriteLine($"{input} was found");
                }
                else
                {
                    Console.WriteLine($"{input} counld not find");
                }
            }

        }
    }
}
