using System;

public class Program
{
    public static void Main()
    {
        int number = GetNumberFromUser("Введите трехзначное число: ");
        int[] digitArray = GetDigitArray(number);

        // Вывод массива
        foreach (int digit in digitArray)
        {
            Console.Write(digit + " ");
        }
    }

    // Функция для создания массива цифр из числа
    public static int[] GetDigitArray(int number)
    {
        int[] digits = new int[3];
        digits[0] = number % 10; // Единицы
        number /= 10;
        digits[1] = number % 10; // Десятки
        number /= 10;
        digits[2] = number; // Сотни
        return digits;
    }

    // Функция для получения числа от пользователя
    public static int GetNumberFromUser(string message)
    {
        bool isValidInput;
        int number;
        do
        {
            Console.Write(message);
            isValidInput = int.TryParse(Console.ReadLine(), out number);
            if (!isValidInput number < 100 || number > 999);
            {
                Console.WriteLine("Ошибка: Введите корректное трехзначное число.");
                isValidInput = false;
            }
        } while (!isValidInput);
        return number;
    }
}


/*
В этом коде:
Создается метод GetNumberFromUser, который спрашивает пользователя о вводе трехзначного числа и проверяет, является ли ввод корректным целым числом. Если ввод некорректен, пользователю выводится сообщение об ошибке, и пользователь снова запрашивается ввести число.
В методе Main используется метод GetNumberFromUser для получения числа от пользователя. Затем создается массив digitArray с помощью метода GetDigitArray, который создает массив цифр из числа number.
В цикле foreach выводится массив digitArray в консоль.
Теперь код проверяет ввод пользователя на ошибки и не прекращает работу до получения корректного числа. 
*/