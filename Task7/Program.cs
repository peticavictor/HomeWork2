using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing text
            String text =   "To be, or not to be, that is the question,\n" +
                            "Whether 'tis nobler in the mind to suffer \n" +
                            "The slings and arrows of outrageous fortune, \n"+
                            "Or to take arms against a sea of troubles, \n"+
                            "And by opposing end them? To die: to sleep; \n"+
                            "No more; and by a sleep to say we end \n"+
                            "The heart-ache and the thousand natural shocks \n"+
                            "That flesh is heir to, 'tis a consummation \n"+
                            "Devoutly to be wish'd. To die, to sleep \n";

            //output text
            Console.WriteLine(text);

            // ask user to input invalid word
            Console.WriteLine("Write invalid word ");
            String invalidWord = Console.ReadLine();

            // initializing a string with value set of '*' characters
            String set = new String('*', invalidWord.Length);

            //replacing invalid word with set of characters
            text = text.Replace(" " + invalidWord + " ", " " + set + " ");

            //capitalising first letter of invalid word
            invalidWord = char.ToUpper(invalidWord[0]) + invalidWord.Substring(1);

            //replacing capitalised invalid word with set of characters
            text = text.Replace(invalidWord + " ", set + " ");

            // split text into array
            String[] words = text.Split(" ");

            //counting replaced words
            int count = 0;
            foreach(String word in words)
            {
                if (word.Equals(set))
                {
                    count++;
                }
            }

            //output text
            Console.WriteLine(text);
            Console.WriteLine("Statistics : " + count + " substitution of the word \'" + invalidWord +"\'");
        }
    }
}
