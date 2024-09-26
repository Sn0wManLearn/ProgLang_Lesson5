using System;
class Program
{
    static void ReplaceNegativeNumbers(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        // Введите свое решение ниже
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < 0) array[i, j] = -array[i, j];
            }
        }
    }

    static void ShowArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] array =
        {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, -8, 9 }
        };
        ReplaceNegativeNumbers(array);
        ShowArray(array);
    }
}
