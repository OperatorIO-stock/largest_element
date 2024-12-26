using System.Globalization;

namespace largest_element;

class Program
{
    static void Main(string[] args)
    {
        int rows = 10;
        int cols = 10;
        int replaceLargerNumberInArray = 0;
        int minNumberArray = 1;
        int maxNumberArray = 10;

        int[,] arrayNumbers = new int[rows, cols];

        Random random = new Random();

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                arrayNumbers[i, j] = random.Next(minNumberArray, maxNumberArray);

        int maxElement = arrayNumbers[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                if (arrayNumbers[i, j] > maxElement)
                    maxElement = arrayNumbers[i, j];
        }

        Console.WriteLine($"Max number of the matrix: {maxElement}\n");
        Console.WriteLine("The original version of the matrix");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write($"{arrayNumbers[i, j]} ");
            
            Console.WriteLine();
        }

        Console.WriteLine("\nThe resulting matrix");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arrayNumbers[i, j] == maxElement)
                    arrayNumbers[i, j] = replaceLargerNumberInArray;
                
                Console.Write($"{arrayNumbers[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}
