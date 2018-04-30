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

                //Idetify vowels in user input
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                int index = input.ToLower().IndexOfAny(vowels);

                //Divide words utilizing the substring
                string firstVowel = input.Substring(index);
                string restOfWord = input.Substring(0, index);

                /* If any of the vowels listed are in the first placeholder add 
                 "way" to the end of input */

                if (index == 0)
                    {
                        Console.WriteLine(input + "way");
                    }

                /*Identify any vowels and make the first one the "0" placeholder add 
                "ay" to the letters(consonants) that follow */

                else if (index != 0)
                    {
                        Console.WriteLine(firstVowel + restOfWord + "ay");
                    }


                Console.WriteLine("Would you like to translate another line? (Y/N)");
                string play = Console.ReadLine();

                //Give the user the option to continue
                if (play.ToLower() != "y")
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }


            }

        }
    }

}
