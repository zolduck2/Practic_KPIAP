using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите нижнюю границу диапазона a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите верхнюю границу диапазона b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение E: ");
        int E = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение F: ");
        int F = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер столбца k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();
        int[,] matrix = new int[N, N];

        // Заполнение матрицы и вывод на экран
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Вычисление суммы квадратов элементов, принадлежащих промежутку (E, F]
        int sumSquares = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] > E && matrix[i, j] <= F)
                {
                    sumSquares += matrix[i, j] * matrix[i, j];
                }
            }
        }
        Console.WriteLine("Сумма квадратов элементов, принадлежащих промежутку (E, F]: " + sumSquares);

        // Вычисление суммы элементов k-того столбца
        int columnSum = 0;
        for (int i = 0; i < N; i++)
        {
            columnSum += matrix[i, k];
        }
        Console.WriteLine("Сумма элементов " + k + "-го столбца: " + columnSum);
    }
}
