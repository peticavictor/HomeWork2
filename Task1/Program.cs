using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring a 5 elements one-dimentional array named A
            double[] A = new double[5];

            // Declaring a two-dimensional array[3][4] named B
            double[,] B = new double[3,4];

            // ask user to input 5 numbers to array A
            Console.WriteLine("Input numbers in array A :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("A[" + i + "] = ");
                A[i] = double.Parse(Console.ReadLine());
            }

            // creating Random object
            Random random = new Random();

            // fill array B with the random values 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i,j] = random.NextDouble() * 10;
                }
            }

            // declaring and initializing doubles min and max
            double min = double.MaxValue, max = double.MinValue;

            //declaring and initializing sum variable
            double sum = 0;

            //declaring and initializing product variable
            double product = 1;

            //declaring and initializing sumA variable
            double sumA = 0;

            //declaring and initializing sumA variable
            double sumB = 0;

            // output valuest from array A
            Console.Write("A = ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i].ToString().PadLeft(4));

                // finding min element
                if ( min > A[i]) min = A[i];

                //finding max element
                if (max < A[i]) max = A[i];

                // adding all elements to sum
                sum += A[i];

                // multiplying all elements
                product *= A[i];

                // adding even elements from array A to sumA
                if (i % 2 == 0) sumA += A[i];
            }

            // output valuest from array B
            Console.WriteLine("\nB = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                { 
                    Console.Write(B[i,j].ToString("f" + 1).PadLeft(4));

                    // finding min element
                    if (min > B[i,j]) min = B[i, j];

                    //finding max element
                    if (max < B[i, j]) max = B[i, j];

                    // adding all elements to sum
                    sum += B[i,j];

                    // multiplying all elements
                    product *= B[i, j];

                    // adding elements from odd columns in the array B to sumB
                    if (j % 2 != 0) sumB += B[i,j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // output the total maximum element
            Console.WriteLine("The total maximum element = " + max.ToString("f" +1));

            // output the total minimum element
            Console.WriteLine("The total minimum element = " + min.ToString("f" +1));

            // output the summ of all elements
            Console.WriteLine("The total sum = " + sum.ToString("f" +1));

            // output the summ of even elements from array A
            Console.WriteLine("The sum of even elements from array A = " + sumA.ToString("f" +1));

            // output the summ of elements from odd columns in the array B
            Console.WriteLine("The sum of elements from odd columns in the array B = " + sumB.ToString("f" +1));
        }
    }
}
