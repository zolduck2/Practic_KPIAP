using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = { 17, 3, 76, 87 };
        int sumLimit = 535;
        int productLimit = 535;

        Parallel.ForEach(numbers, (number, state) =>
        {
            int sum = 0;
            long product = 1;

            for (int i = 0; i <= number; i++)
            {
                sum += i;
                product *= i;

                if (sum > sumLimit || product > productLimit)
                {
                    Console.WriteLine($"Прерывание выполнения для числа {number}. Сумма: {sum}, Произведение: {product}");
                    state.Break();
                    return;
                }
            }

            Console.WriteLine($"Вычисление завершено для числа {number}. Сумма: {sum}, Произведение: {product}");
        });
    }
}
