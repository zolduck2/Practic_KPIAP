byte n = 1; byte i;
try
{
    checked //блок с проверкой
    {
        n = 1;
        for (i = 1; i < 10; i++) n *= i;
        Console.WriteLine($"2: {n}");
    }

    unchecked //блок без проверки  
    {
        for (i = 1; i < 10; i++) n *= i;
        Console.WriteLine($"1: {n}");
    }
    
}
catch (OverflowException)
{
    Console.WriteLine("возникло переполнение");
}

