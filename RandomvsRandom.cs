// Created by Umut on 23/7/2022 
//
// Random vs Random
//
namespace RandomvsRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Random vs Random");
            Console.WriteLine("-----------------------------------------------------");
            RandomRandom();
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadLine();
        }

        static void RandomRandom()
        {
            Random randObj = new Random();
            int number1 = randObj.Next(100);
            int number2;
            int counter = 0;
            while (true)
            {
                Console.WriteLine("Random vs Random");
                number2 = randObj.Next(100);
                counter++;
                if (number1 == number2)
                {
                    Console.WriteLine("True: {0} vs {1}, {2}.try", number1, number2, counter);
                    break;
                }
                else
                {
                    Console.WriteLine("True: {0} vs {1}, {2}.try", number1, number2, counter);
                }
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}