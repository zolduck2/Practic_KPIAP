using System;

class MyArray : IComparable<MyArray>
{
    private string[] array;

    public MyArray(int size, int lowerBound, int upperBound)
    {
        if (size <= 0 || lowerBound >= upperBound)
            throw new ArgumentException("Неверные параметры");

        array = new string[size];
        LowerBound = lowerBound;
        UpperBound = upperBound;
    }
    public int LowerBound { get; }
    public int UpperBound { get; }
    public string this[int index]
    {
        get
        {
            if (index < LowerBound || index >= UpperBound)
                throw new IndexOutOfRangeException("Индекс за пределами");
            return array[index - LowerBound];
        }
        set
        {
            if (index < LowerBound || index >= UpperBound)
                throw new IndexOutOfRangeException("Индекс за пределами");
            array[index - LowerBound] = value;
        }
    }

    public MyArray Concatenate(MyArray other)
    {
        if (other == null || other.LowerBound != LowerBound || other.UpperBound != UpperBound)
            throw new ArgumentException("Массивы должны иметь одинаковый размер.");

        MyArray result = new MyArray(array.Length, LowerBound, UpperBound);
        for (int i = 0; i < array.Length; i++)
            result[i] = array[i] + other[i];
        return result;
    }

    public override string ToString()
    {
        return string.Join(", ", array);
    }

    public int CompareTo(MyArray other)
    {
        int thisTotalLength = 0;
        int otherTotalLength = 0;
        foreach (var str in array)
            thisTotalLength += str.Length;
        foreach (var str in other.array)
            otherTotalLength += str.Length;
        return thisTotalLength.CompareTo(otherTotalLength);
    }
}
class Program
{
    static void Main()
    {
        MyArray array1 = new MyArray(3, 0, 3);
        array1[0] = "Apple";
        array1[1] = "Banana";
        array1[2] = "Cherry";

        MyArray array2 = new MyArray(3, 0, 3);
        array2[0] = "X";
        array2[1] = "Y";
        array2[2] = "Z";

        Console.WriteLine($"Первый массив: {array1}");
        Console.WriteLine($"Второй массив: {array2}");
        MyArray concatenatedArray = array1.Concatenate(array2);
        Console.WriteLine($"Соединенные массивы: {concatenatedArray}");

        try
        {
            Console.WriteLine($"Элемент с индексом 1: {array1[1]}");
            Console.WriteLine($"Элемент с индексом 5: {array1[5]}");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
}

