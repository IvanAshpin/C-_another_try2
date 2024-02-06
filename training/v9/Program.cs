/*
Задача 3: Напишите программу, которая перевернёт одномерный массив
(первый элемент станет последним, второй – предпоследним и т.д.)
*/

using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 6, 44, 5, 3, 9, 43 };
        int temp;
        Console.Write("Исходный массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
        Console.Write("\nПеревернутый массив: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}