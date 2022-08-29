// Created by Umut on 23/7/2022
//
// Finding Number
//
namespace FindingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Finding Number");
            Console.WriteLine("-----------------------------------------------------");
            FindNumber();
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadLine();
        }

        static void FindNumber()
        {
            Random randomObject = new Random();
            int randomNumber = randomObject.Next(1, 100);
            int number = 0, count = 0;

            while (number != randomNumber)
            {
                count++;
                Console.WriteLine("Enter Number (0-100)");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("BRAVO.You find {0}. try, {1}", count, number);
                }
                if (number > randomNumber)
                {
                    Console.WriteLine("Your number too BIG. {0}. try", count);
                }
                if (number < randomNumber)
                {
                    Console.WriteLine("Your number too SMALL. {0}. try", count);
                }
            }
        }
    }
}