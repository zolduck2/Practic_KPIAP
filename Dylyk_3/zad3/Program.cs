using System;

public class Matrix
{
    private int[,] data;

    public Matrix(int rows, int cols)
    {
        data = new int[rows, cols];
    }

    public int Rows
    {
        get { return data.GetLength(0); }
    }

    public int Cols
    {
        get { return data.GetLength(1); }
    }

    public int this[int i, int j]
    {
        get { return data[i, j]; }
        set { data[i, j] = value; }
    }

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

class Program
{
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
