using System.Globalization;

namespace largest_element;

class Program
{
    static void Main(string[] args)
    {
        int rows = 10;
        int cols = 10;

        int[,] array = new int[rows, cols];

        Random random = new Random();

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                array[i, j] = random.Next(1, 10);

        int maxElement = array[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                if (array[i, j] > maxElement)
                    maxElement = array[i, j];
        }

        Console.WriteLine($"Max number of the matrix: {maxElement}\n");
        Console.WriteLine("The original version of the matrix");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write($"{array[i, j]} ");
            
            Console.WriteLine();
        }

        Console.WriteLine("\nThe resulting matrix");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] == maxElement)
                    array [i, j] = 0;
                
                Console.Write($"{array[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}
