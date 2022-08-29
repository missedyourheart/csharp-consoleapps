// Created by Umut on 23/7/2022 
//
// Finding Word
//
using System.Text;

namespace FindingWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Finding Word");
            Console.WriteLine("-----------------------------------------------------");
            FindWord();
            Console.WriteLine("-----------------------------------------------------");

            Console.ReadLine();
        }

        static void FindWord()
        {
            int counter = 0;
            string word = "mywordmy";
            //string hiddenWord = "myword";
            string hiddenWord = new string('_', word.Length);
            StringBuilder sb = new StringBuilder(hiddenWord);
            //Console.WriteLine(hiddenWord);

            while (true)
            {
                counter++;
                Console.WriteLine(hiddenWord);
                Console.WriteLine("Enter character-");
                char myKey = Console.ReadKey().KeyChar;
                if (Char.IsLetter(myKey))
                {
                    myKey = Char.ToLower(myKey);
                    //Console.WriteLine(myKey + "" + myKey.GetTypeCode());
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == myKey)
                        {
                            sb[i] = myKey;
                            hiddenWord = sb.ToString();
                        }
                    }
                    Console.Clear();
                    Console.WriteLine(hiddenWord);
                    if (hiddenWord == word)
                    {
                        Console.WriteLine("Your find the word {0}. try", counter);
                        break;
                    }
                }
            }
        }
    }
}