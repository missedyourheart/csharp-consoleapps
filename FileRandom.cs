// Created by Umut on 23/7/2022 
//
// File Random
//
namespace FileRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## File Random");
            Console.WriteLine("-----------------------------------------------------");
            string filePath = "/*TEXT URL*/";
            RandomFile(filePath);
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadLine();
        }

        static void RandomFile(string path)
        {
            Random randObject = new Random();
            string[] readfileText = File.ReadAllLines(path);
            int randomNumber = randObject.Next(readfileText.Length);
            foreach (var item in readfileText)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Random:{0}", readfileText[randomNumber]);
        }
    }
}