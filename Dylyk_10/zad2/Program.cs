using System;

class A
{
    public int a;
    public int b; 

    public int C => a + b;

    public A()
    {
        a = 10;
        b = 20;
    }
}

class B : A
{
    private int d; 

    public B() : base()
    {
        d = 5;
    }

    public B(int a, int b, int d)
    {
        this.a = a;
        this.b = b;
        this.d = d;
    }

    public int C2
    {
        get
        {
            if (d > 0)
                return a * b * d;
            else
                return a + b;
        }
    }
}

class Program
{
    static void Main()
    {
        A objA = new A();
        B objB1 = new B();
        B objB2 = new B(15, 25, 3);

        Console.WriteLine($"Значение свойства \"с\" в объекте класса \"А\": {objA.C}");
        Console.WriteLine($"Значение свойства \"с2\" в объекте класса \"В\" (конструктор 1): {objB1.C2}");
        Console.WriteLine($"Значение свойства \"с2\" в объекте класса \"В\" (конструктор 2): {objB2.C2}");
    }
}

