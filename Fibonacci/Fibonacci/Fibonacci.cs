using System;

class Program
{
    static void Main()
    {
        // Введення номера числа Фібоначчі
        Console.Write("Введiть номер числа Фiбоначчi: ");
        int n = int.Parse(Console.ReadLine());

        long a = 0;
        long b = 1;
        long result = 0;

        Console.WriteLine("\nПослiдовнiсть Фiбоначчi:");

        // Обчислення та виведення чисел від F(0) до F(n)
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine($"F({i}) = {a}");

            // Запам'ятовуємо поточне число
            result = a;

            // Наступне число дорівнює сумі двох попередніх
            long next = a + b;
            a = b;
            b = next;
        }

        // Виведення потрібного числа
        Console.WriteLine($"\nF({n}) = {result}");
    }
}
