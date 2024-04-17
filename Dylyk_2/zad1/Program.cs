using System;

public class A
{
    public int a { get; set; }
    public int b { get; set; }

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double CalculateExpression()
    {
        return Math.Pow(b, 3) - 4 * Math.Sqrt(a);
    }

    public double SquareOfQuotient()
    {
        if (b == 0)
        {
            throw new DivideByZeroException("b не может быть равно нулю");
        }
        double quotient = (double)a / b;
        return Math.Pow(quotient, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        A obj = new A(4, 2);
        Console.WriteLine("Значение выражения b^3-4√a: " + obj.CalculateExpression());
        Console.WriteLine("Квадрат частного a и b: " + obj.SquareOfQuotient());
    }
}
