// Напишите программу, которая принимает на вход целое числ
 // из отрезка [10, 99] и показывает наибольшую цифру числа.

Random rnd = new Random();
int a = rnd.Next(10, 99);
Console.WriteLine(a);
int num1 = a / 10;
int num2 = a % 10;
if (num1 > num2){Console.WriteLine(num1);}
else {Console.WriteLine(num2);}