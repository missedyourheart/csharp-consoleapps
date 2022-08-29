// Created by Umut on 23/7/2022 
//
// Patterns
//
namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Patterns");
            Console.WriteLine("-----------------------------------------------------");
            Pattern1();
            Console.WriteLine("-----------------------------------------------------");
            Pattern2();
            Console.WriteLine("-----------------------------------------------------");
            Pattern3();
            Console.WriteLine("-----------------------------------------------------");
            Pattern4();
            Console.WriteLine("-----------------------------------------------------");
            Pattern5();
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadLine();
        }

        static void Pattern1()
        {
            int row = 5;
            string pattern = "*";
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(pattern);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = row; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(pattern);
                }
                Console.WriteLine();
            }
        }
        static void Pattern2()
        {
            int delay = 200; //0.2s
            int stringLength = 6;
            string[] patternArray = new string[stringLength];
            string pattern = "*";

            for (int i = 0; i < patternArray.Length; i++)
            {
                for (int j = 0; j < patternArray.Length; j++)
                {
                    if (i == j)
                    {
                        patternArray[j] = pattern;
                    }
                    else
                    {
                        patternArray[j] = " ";
                    }
                }
                //patternArray[i] = pattern;
                foreach (var item in patternArray)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(delay);
            }
        }
        static void Pattern3()
        {
            int row = 5;
            int count;
            string pattern = "*";
            count = row - 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");

                }
                count--;
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(pattern);
                }
                Console.WriteLine();
            }
            count = 1;
            for (int i = 1; i <= row - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int j = 1; j <= 2 * (row - i) - 1; j++)
                {
                    Console.Write(pattern);
                }
                Console.WriteLine();
            }
        }
        static void Pattern4()
        {
            int row = 5;
            string pattern = "*";
            for (int i = 0; i < row; i++)
            {
                if (i == 0 || i == row - 1)
                {
                    for (int j = 0; j < row; j++)
                    {
                        Console.Write(pattern);
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= row - 2)
                {
                    for (int j = 0; j < row; j++)
                    {
                        if (j == 0 || j == row - 1)
                        {
                            Console.Write(pattern);
                        }
                        else if (j >= 1 && j <= row - 2)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Pattern5()
        {
            int row = 5;
            string pattern = "*";
            for (int i = 1; i <= row; i++)
            {
                for (int j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (j == 1 || j == (2 * i - 1))
                    {
                        Console.Write(pattern);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = row; i >= 0; i--)
            {
                for (int j = i; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    if (j == 1 || j == (2 * i - 1))
                    {
                        Console.Write(pattern);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}