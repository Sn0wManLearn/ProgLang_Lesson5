using System;
class Program
{
    static void FindSumInColumns(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int i = 0; i < cols; i++)
        {
            int sum = 0;
            for (int j = 0; j < rows; j++)
            {
                sum += array[j, i];
            }
            Console.WriteLine($"Сумма элементов в столбце {i}: {sum}");
        }
    }
    static void Main()
    {
        int[,] array =
        {
            { 5, 2, 8 },
            { 4, 9, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };
        FindSumInColumns(array);
    }
}
