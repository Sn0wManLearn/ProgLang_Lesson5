using System;
class Program
{
    static void FindMaxInRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int max = array[i, 0];
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] > max) max = array[i, j];
            }
            Console.WriteLine($"Максимальный элемент в строке {i}: {max}");
        }
    }
    static void Main()
    {
        int[,] array =
        {
            { 9, 3, 5, 7 },
            { 2, 4, 22, 8 },
            { 9, 10, 11, 30 }
        };
        FindMaxInRows(array);
    }
}