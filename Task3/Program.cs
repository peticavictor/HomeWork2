using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to input text 
            Console.Write("Input text for encoding : ");
            String text = Console.ReadLine();

            // ask for cipering key
            Console.Write("Input cifering key : ");
            int key = int.Parse(Console.ReadLine());

            // cifering
            String eText = String.Empty;

            foreach(char ch in text)
            {
                if (!char.IsLetter(ch))
                {
                    eText += ch;
                }
                else
                {
                    char ch1 = char.IsUpper(ch) ? 'A' : 'a';
                    eText += (char)((((ch + key) - ch1) % 26) + ch1);
                }
                
            }

            //output cifered text
            Console.WriteLine(eText);

            // decipher
            text = String.Empty;

            foreach(char ch in eText)
            {
                if (!char.IsLetter(ch))
                {
                    text += ch;
                }
                else
                {
                    char ch1 = char.IsUpper(ch) ? 'A' : 'a';
                    text += (char)((((ch + (26 - key)) - ch1) % 26) + ch1);
                }
            }

            //output decifered text
            Console.WriteLine(text);
        }
    }
}
