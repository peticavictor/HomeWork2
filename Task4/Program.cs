using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the matrix of int values
            const int size = 10;
            int[,] matrix = new int[size, size];

            //Creating Random object
            Random random = new Random();

            // asign random values for all elements in matrix
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                    Console.Write(matrix[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

            // ask user to insert the multiplier  
            Console.WriteLine("Input multiplying number : ");
            int multiplier = int.Parse(Console.ReadLine());

            // multiplying and output matrix 
            Console.WriteLine("Multiplied Matrix : \n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = matrix[i, j] * multiplier;
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //creating the second matrix of int values
            int[,] secondMatrix = new int[size, size];

            //creating the third matrix of int values
            int[,] thirdMatrix = new int[size, size];

            // asign random values for all elements in secondMatrix
            for (int i = 0; i < size; i++)
            {
                //output both matrices in paralel
                //output second matrix
                for (int j = 0; j < size; j++)
                {
                    secondMatrix[i, j] = random.Next(-10, 10);
                    Console.Write(secondMatrix[i, j].ToString().PadLeft(3));

                    //adition of matrices with saving result in third matrix
                    thirdMatrix[i, j] = secondMatrix[i, j] + matrix[i, j];
                }
                Console.Write("\t\t");
                
                //output the first matrix
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

            // output third matrix
            Console.WriteLine("\n Third Martix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(thirdMatrix[i, j].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

            // multiplying secondMatrix with third matrix and saving results in first matrix
            // and output first matrix
            Console.WriteLine("\n first Martix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = secondMatrix[i, j] * thirdMatrix[i, j];
                    Console.Write(matrix[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }
    }
}
