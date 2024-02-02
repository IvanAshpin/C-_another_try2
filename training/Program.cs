//CompareNumbers(int firstNumber, int secondNumber);
int firstNumber =19;
int secondNumber = 8;

{
    if (firstNumber < secondNumber)
        Console.WriteLine("Первое число `" + firstNumber + "` меньше чем второе число `" + secondNumber + "`");
    else
        if (firstNumber == secondNumber)
        Console.WriteLine("Введенные числа равны `" + firstNumber + "`");
    else
        Console.WriteLine("Первое число `" + firstNumber + "` больше чем второе число `" + secondNumber + "`");
}