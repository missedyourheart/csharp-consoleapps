// Created by Umut on 23/7/2022 
//
// Loading
//
namespace Loading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Loading");
            Console.WriteLine("-----------------------------------------------------");
            Loading();
            Console.WriteLine("\n-----------------------------------------------------");

            Console.ReadLine();
        }

        static void Loading()
        {
            string animation = @"|/-\";
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("[");
                var progress = (int)((i / 10f) + .5f);
                for (int j = 0; j < 10; j++)
                {
                    if (j >= progress)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.Write("] {0}% {1}", i, animation[i % 4]);
                System.Threading.Thread.Sleep(50);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
        }
    }
}