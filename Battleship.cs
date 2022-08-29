// Created by Umut on 23/7/2022 
//
// Battleship, Battleship vs Random
//
namespace Battleship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Battleship");
            Console.WriteLine("-----------------------------------------------------");
            //Battleship();
            BattleShipvsRandom();
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadLine();
        }

        static void Battleship()
        {
            string pattern = "-";
            string[,] boardArray = new string[5, 9];
            Random randObject = new Random();
            int[] random = { randObject.Next(boardArray.GetLength(0)), randObject.Next(boardArray.GetLength(1)) };
            int number, number1 = 0, number2 = 0;

            for (int i = 0; i < boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardArray[i, j] = pattern;
                }
            }
            ArrayWrite(boardArray);

            while (true)
            {
                Console.WriteLine("Enter Number-" + (random[0] + 1) + "" + (random[1] + 1));
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 10 && number <= ((boardArray.GetLength(0) * 10) + boardArray.GetLength(1)))
                {
                    if (number % 10 != 0)
                    {
                        number2 = number % 10;
                        number1 = (number - number2) / 10;

                        if (number1 - 1 == random[0] && number2 - 1 == random[1])
                        {
                            boardArray[number1 - 1, number2 - 1] = "#";
                            Console.WriteLine("BATTLESHIP!");
                            Console.Clear();
                            ArrayWrite(boardArray);
                            break;
                        }
                        else
                        {
                            boardArray[number1 - 1, number2 - 1] = "*";
                        }
                        Console.Clear();
                        ArrayWrite(boardArray);
                    }
                }
            }
        }
        static void ArrayWrite(string[,] myArray)
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void BattleShipvsRandom()
        {
            string pattern = "-";
            string[,] boardArray = new string[5, 9];
            string[,] boardArray2 = new string[5, 9];
            Random randObject = new Random();
            int[] random = { randObject.Next(boardArray.GetLength(0)), randObject.Next(boardArray.GetLength(1)) };
            int[] random2 = { randObject.Next(boardArray2.GetLength(0)), randObject.Next(boardArray2.GetLength(1)) };
            int number, number1 = 0, number2 = 0;
            int randNumber1 = 0, randNumber2 = 0;

            for (int i = 0; i < boardArray.GetLength(0); i++)
            {
                for (int j = 0; j < boardArray.GetLength(1); j++)
                {
                    boardArray[i, j] = pattern;
                    boardArray2[i, j] = pattern;
                }
            }
            ArrayWrite(boardArray);
            Console.WriteLine();
            ArrayWrite(boardArray2);

            while (true)
            {
                Console.WriteLine("Enter Number-" + (random[0] + 1) + "" + (random[1] + 1));
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 10 && number <= ((boardArray.GetLength(0) * 10) + boardArray.GetLength(1)))
                {
                    if (number % 10 != 0)
                    {
                        number2 = number % 10;
                        number1 = (number - number2) / 10;

                        if (number1 - 1 == random[0] && number2 - 1 == random[1])
                        {
                            boardArray[number1 - 1, number2 - 1] = "#";
                            Console.Clear();
                            ArrayWrite(boardArray);
                            Console.WriteLine();
                            ArrayWrite(boardArray2);
                            Console.WriteLine("WIN!");
                            break;
                        }
                        else
                        {
                            boardArray[number1 - 1, number2 - 1] = "*";

                            randNumber1 = randObject.Next(boardArray2.GetLength(0));
                            randNumber2 = randObject.Next(boardArray2.GetLength(1));
                            Console.WriteLine(randNumber1 + "" + randNumber2);
                            if (randNumber1 == random2[0] && randNumber2 == random2[1])
                            {
                                boardArray2[randNumber1, randNumber2] = "#";
                                Console.Clear();
                                ArrayWrite(boardArray);
                                Console.WriteLine();
                                ArrayWrite(boardArray2);
                                Console.WriteLine("RANDOM WIN!");
                                break;
                            }
                            else
                            {
                                boardArray2[randNumber1, randNumber2] = "*";
                            }
                        }
                        Console.Clear();
                        ArrayWrite(boardArray);
                        Console.WriteLine();
                        ArrayWrite(boardArray2);

                    }
                }
            }
        }
    }
}