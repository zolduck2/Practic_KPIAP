using System;

class Program
{
    static void Main()
    {
        int N = 7;
        int[,] matrix = new int[N, N];
        int number = 1;
        int rowStart = 0, rowEnd = N - 1;
        int colStart = 0, colEnd = N - 1;

        while (number <= N * N)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = number++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = number++;
            }
            colEnd--;

            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = number++;
            }
            rowEnd--;

            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = number++;
            }
            colStart++;
        }

        // Вывод матрицы
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
