using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер строки для проверки: ");
        int rowNumber = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();
        int[,] matrix = new int[N, N];

        // Заполнение матрицы и вывод на экран
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(-10, 10 + 1); // Генерирует случайное число от -100 до 100
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Вычисление суммы элементов заданной строки
        int rowSum = 0;
        for (int j = 0; j < N; j++)
        {
            rowSum += matrix[rowNumber, j];
        }

        // Проверка, оканчивается ли сумма цифрой 0
        if (rowSum % 10 == 0)
        {
            Console.WriteLine("Сумма элементов строки " + rowNumber + " оканчивается цифрой 0.");
        }
        else
        {
            Console.WriteLine("Сумма элементов строки " + rowNumber + " не оканчивается цифрой 0.");
        }
    }
}

