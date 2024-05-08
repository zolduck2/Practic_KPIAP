using System;

/// <summary>
/// Класс Matrix представляет двумерный массив.
/// </summary>
public class Matrix
{
    /// <summary>
    /// Двумерный массив для хранения данных матрицы.
    /// </summary>
    private int[,] data;

    /// <summary>
    /// Конструктор класса Matrix.
    /// </summary>
    /// <param name="rows">Количество строк в матрице.</param>
    /// <param name="cols">Количество столбцов в матрице.</param>
    public Matrix(int rows, int cols)
    {
        data = new int[rows, cols];
    }

    /// <summary>
    /// Возвращает количество строк в матрице.
    /// </summary>
    public int Rows
    {
        get { return data.GetLength(0); }
    }

    /// <summary>
    /// Возвращает количество столбцов в матрице.
    /// </summary>
    public int Cols
    {
        get { return data.GetLength(1); }
    }

    /// <summary>
    /// Индексатор для доступа к элементам матрицы.
    /// </summary>
    public int this[int i, int j]
    {
        get { return data[i, j]; }
        set { data[i, j] = value; }
    }

    /// <summary>
    /// Оператор -- удаляет первый столбец матрицы.
    /// </summary>
    public static Matrix operator --(Matrix m)
    {
        int[,] newData = new int[m.Rows, m.Cols - 1];
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols - 1; j++)
            {
                newData[i, j] = m[i, j + 1];
            }
        }
        m.data = newData;
        return m;
    }
}

/// <summary>
/// Класс Program содержит точку входа в программу.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        Matrix m = new Matrix(rows, cols);
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                m[i, j] = i * m.Cols + j;
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintMatrix(m);

        Console.Write("Введите количество столбцов для удаления: ");
        int numColsToRemove = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numColsToRemove; i++)
        {
            m--;
        }

        Console.WriteLine("Массив после удаления столбцов:");
        PrintMatrix(m);
    }

    /// <summary>
    /// Метод для печати матрицы.
    /// </summary>
    /// <param name="m">Матрица для печати.</param>
    static void PrintMatrix(Matrix m)
    {
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
