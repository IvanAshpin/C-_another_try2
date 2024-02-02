﻿/*
Для тех кому интересно (кто был сегодня на Знакомство с языками программирования (семинары)Урок 3. Массивы)
Мы по времени не успели разобрать 
Задание 4*. Совместная работа
[если позволит тайминг]
Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7] 

//Решил немного разобрать, вот результат:

//1)
*/

using System;

public class Program
{
    public static void Main()
    {
        int number = 873; // Замените 456 на входное число
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
}


/*
Эта программа определяет функцию GetDigitArray для извлечения цифр и сохранения их в массиве.
Затем функция Main демонстрирует, как использовать эту функцию и выводить полученный массив.
Этот код следует принципам чистого кода, используя описательные имена переменных и отдельную функцию для основной логики.
Приведенная выше программа на C# создает массив цифр из трехзначного числа и следует принципам чистого кода,включая комментарии для ясности.
Функция GetDigitArray извлекает цифры и сохраняет их в массиве, а функция Main демонстрирует,
как использовать эту функцию и выводить полученный массив.
*/