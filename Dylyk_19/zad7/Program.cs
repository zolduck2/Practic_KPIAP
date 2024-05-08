using System;

/// <summary>
/// Класс Program содержит основную логику программы.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
    static void Main(string[] args)
    {
        /// <summary>
        /// Делегат Add выполняет операцию сложения.
        /// </summary>
        Func<double, double, double> Add = (x, y) => x + y;

        /// <summary>
        /// Делегат Sub выполняет операцию вычитания.
        /// </summary>
        Func<double, double, double> Sub = (x, y) => x - y;

        /// <summary>
        /// Делегат Mul выполняет операцию умножения.
        /// </summary>
        Func<double, double, double> Mul = (x, y) => x * y;

        /// <summary>
        /// Делегат Div выполняет операцию деления.
        /// </summary>
        Func<double, double, double> Div = (x, y) => y != 0 ? x / y : throw new DivideByZeroException();

        Console.WriteLine("Введите два числа:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию (Add, Sub, Mul, Div):");
        string operation = Console.ReadLine();

        double result = 0;
        switch (operation)
        {
            case "Add":
                result = Add(num1, num2);
                break;
            case "Sub":
                result = Sub(num1, num2);
                break;
            case "Mul":
                result = Mul(num1, num2);
                break;
            case "Div":
                try
                {
                    result = Div(num1, num2);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Неизвестная операция!");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}
