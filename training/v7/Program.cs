//Задача 1: Бесконечный запрос чисел до ввода ‘q’ или числа с четнойсуммой цифр
using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine();
            if (input == "q")
            {
                Console.WriteLine("[Q -> out]");
                break;
            }
            int number;
            if (int.TryParse(input, out number))
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine("[even sum -> out]");
                    break;
                }
            }
            else
            {
                Console.WriteLine("no 'Q' or no even sum...try more .");
            }
        }
    }
}
