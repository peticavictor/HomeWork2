using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring a two dimensional array [5,5]
            int[,] array = new int[5, 5];

            // declaring a Random object
            Random random = new Random();

            // declaring and initializing min and max variables
            int min = int.MaxValue, max = int.MinValue;

            // declaring variables for saving indexes of max and min values
            int[] minIndex = new int[2];
            int[] maxIndex = new int[2];

            // filling and outputing array with random numbers from -100 to 100
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 100);
                    Console.Write(array[i,j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            //finding minimum and maximum elements
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ( min > array[i, j])
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                    
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }

            // output indexes o minimum and maximum
            Console.WriteLine("MinIndex = ["+ minIndex[0] + "," + minIndex[1] +"]");
            Console.WriteLine("MaxIndex = ["+ maxIndex[0] + "," + maxIndex[1] +"]");

            //checking if range boundaries are specified correctly (if min and max are in ascendent order)
            if ( (minIndex[0] > maxIndex[0]) || (minIndex[0] == maxIndex[0] && minIndex[1] > maxIndex[1]) )
            {
                (minIndex, maxIndex) = (maxIndex, minIndex);
            }

            // declaring and initializing the sum variable
            int sum = 0;

            // determining the sum between maximum and minimum elements
            for (int i = minIndex[0]; i <= maxIndex[0]; i++)
            {
                // setting j depending of i 
                // start value : if (i == row of min) j = column of min
                // end value   : if (i == row of max) j < column of max
                for (int j = (i == minIndex[0] ? minIndex[1] : 0) ; j < ( i == maxIndex[0] ? maxIndex[1] : 5); j++)
                {
                    sum += array[i, j];
                }
            }

            // printing sum between min and max
            Console.WriteLine("Sum between " + min + " and " + max + " = " + sum);
        }
    }
}
