// Created by Umut on 23/7/2022 
//
// Rock Paper Scissors
//
namespace RockPaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Rock Paper Scissors");
            Console.WriteLine("-----------------------------------------------------");
            RockPaper();
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadLine();
        }

        static void RockPaper()
        {
            Random randObj = new Random();
            string random1, random2;
            int counter = 0;
            string[] rpsArray = { "rock", "paper", "scissors" };

            while (counter < 5)
            {
                counter++;
                random1 = rpsArray[randObj.Next(3)];
                random2 = rpsArray[randObj.Next(3)];
                if (random1 != random2)
                {
                    if ((random1 == "rock" && random2 == "paper") || (random1 == "paper" && random2 == "rock"))
                    {
                        Console.WriteLine("{0} vs {1}, paper win!", random1, random2);
                    }
                    if ((random1 == "scissors" && random2 == "paper") || (random1 == "paper" && random2 == "scissors"))
                    {
                        Console.WriteLine("{0} vs {1}, scissors win!", random1, random2);
                    }
                    if ((random1 == "scissors" && random2 == "rock") || (random1 == "rock" && random2 == "scissors"))
                    {
                        Console.WriteLine("{0} vs {1}, rock win!", random1, random2);
                    }
                }
                else
                {
                    Console.WriteLine("Same");
                }
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}