using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to input expresion which needs to calculate 
            Console.Write("Input expression : ");
            String expression = Console.ReadLine();

            // counting number of operations
            int opNum = 0;
            foreach(char ch in expression)
            {
                if(ch.Equals('+') || ch.Equals('-'))
                {
                    opNum++;
                }
            }

            // declaring an array of operations 
            char[] operations = new char[opNum];

            //reseting opNum
            opNum = 0;

            // add all operations into array operations
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].Equals('+') || expression[i].Equals('-'))
                {
                    operations[opNum++] = expression[i];
                }
            }

            //split expression into array of Strings
            String[] numbers = expression.Split(operations);

            // cast array of strings to array of integers   
            int[] ints = Array.ConvertAll(numbers, str => int.Parse(str));

            //calculating result of expression
            //saving result in first element of "ints" array
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                switch(operations[i])
                {
                    case '+':
                        ints[0] += ints[i+1];
                        break;
                    case '-':
                        ints[0] -= ints[i+1];
                        break;
                }
            }

            //output result
            Console.WriteLine(expression + " = " + ints[0]);

        }
    }
}
