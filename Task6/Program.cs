using System;
using System.Text;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to input a text
            Console.WriteLine("Input text :");
            String text = Console.ReadLine();

            // creating a StringBuilder object
            var resultText = new StringBuilder(text.Length);

            // creating and instantiating a bool variable with value true
            bool isNewSentence = true;

            // capitalize first letter of all sentences
            for (int i = 0; i < text.Length; i++)
            {
                if (isNewSentence && char.IsLetter(text[i]))
                {
                    resultText.Append(char.ToUpper(text[i]));
                    isNewSentence = false;
                }
                else
                {
                    resultText.Append(text[i]);
                }

                if(text[i] == '.' || text[i] == '?' || text[i] == '!')
                {
                    isNewSentence = true;
                }
            }

            Console.WriteLine(resultText);
            
        }
    }
}
