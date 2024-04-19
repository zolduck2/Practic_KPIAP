// Объяснение к примеру
//Исключение DivideByZeroException генерируется, 
//когда f - 1 равно нулю, что приводит к делению на ноль. 
//Но начальное значение f равно 1, и затем f увеличивается умножением на i в цикле for. 
//Это означает, что f - 1 никогда не будет равно нулю, 
//и поэтому исключение DivideByZeroException не будет сгенерировано.

using System;

class Program
{
    static void genException()
    {
        Console.WriteLine("a=");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        double b = double.Parse(Console.ReadLine());
        int f = 1;
        try //Внешний блок-try
        {
            for (double i = a; i <= b; ++i)
            {
                try //Внутренний блок-try
                {
                    f = checked((int)(f * i));
                    if (Math.Abs(f - 1) < 0.000001)
                    {
                        throw new DivideByZeroException("f is too close to 1");
                    }
                    Console.WriteLine($"y({i})={100 / (f - 1):f6}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"y({i})=Деление на 0");
                }
            }
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("ERROR");
            throw; //повторная генерация исключения
        }
    }

    static void Main()
    {
        try
        {
            genException();
        }
        catch
        {
            Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
        }
    }
}
