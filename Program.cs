using System;


namespace Capstone1_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)

            { 
                Console.WriteLine("Please enter a line to be translated: ");
                string input = Console.ReadLine();


                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                int index = input.ToLower().IndexOfAny(vowels);

                string firstVowel = input.Substring(index);
                string restOfWord = input.Substring(0, index);

                if (index == 0)
                    {
                        Console.WriteLine(input + "way");
                    }

                else if (index != 0)
                    {
                        Console.WriteLine(firstVowel + restOfWord + "ay");
                    }


                Console.WriteLine("Would you like to translate another line? (Y/N)");
                string play = Console.ReadLine();

                if (play.ToLower() != "y")
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }


            }

        }
    }

}
