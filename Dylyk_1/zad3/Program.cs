using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите порядковый номер месяца: ");
        int month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("До конца года осталось 11 месяцев.");
                break;
            case 2:
                Console.WriteLine("До конца года осталось 10 месяцев.");
                break;
            case 3:
                Console.WriteLine("До конца года осталось 9 месяцев.");
                break;
            case 4:
                Console.WriteLine("До конца года осталось 8 месяцев.");
                break;
            case 5:
                Console.WriteLine("До конца года осталось 7 месяцев.");
                break;
            case 6:
                Console.WriteLine("До конца года осталось 6 месяцев.");
                break;
            case 7:
                Console.WriteLine("До конца года осталось 5 месяцев.");
                break;
            case 8:
                Console.WriteLine("До конца года осталось 4 месяца.");
                break;
            case 9:
                Console.WriteLine("До конца года осталось 3 месяца.");
                break;
            case 10:
                Console.WriteLine("До конца года осталось 2 месяца.");
                break;
            case 11:
                Console.WriteLine("До конца года остался 1 месяц.");
                break;
            case 12:
                Console.WriteLine("Это последний месяц года.");
                break;
            default:
                Console.WriteLine("Введен некорректный номер месяца.");
                break;
        }
    }
}
