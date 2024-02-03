// Метод для определения является ли число простым
// number - число, которое проверяется на простоту
public static bool IsPrime(int number) // Объявляем публичный статический метод IsPrime с аргументом number типа int и возвращающий значение типа bool (https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/bool)
{
    if (number < 2) return false; // Если число меньше двух, то оно не является простым, возвращаем false

    // Проверяем только делители от 2 до корня из числа
    for (int i = 2; i <= Math.Sqrt(number); i++) // Создаем цикл, который проходит по всем делителям числа от 2 до корня из числа
    {
        if (number % i == 0) // Если число делится на текущий делитель без остатка, то оно не является простым, возвращаем false
        {
            return false;
        }
    }
    return true; // Если цикл завершился без возвращения false, то число является простым, возвращаем true
}

// Метод для вывода результата на экран
// count - количество простых чисел в массиве
// primes - список простых чисел в массиве
public static void PrintResult(int count, List<int> primes) // Объявляем публичный статический метод PrintResult с двумя аргументами: count типа int и primes типа List<int>
{
    Console.WriteLine("Количество простых чисел в массиве: " + count); // Выводим на экран количество простых чисел в массиве
    Console.WriteLine("Список простых чисел в массиве: " + string.Join(", ", primes)); // Выводим на экран список простых чисел в массиве с помощью метода Join класса string
}


class Answer // Объявляем класс Answer
{
    public static void Main(string[] args) // Объявляем публичный статический метод Main с аргументом args типа массив строк
    {
        int[] array; // Объявляем переменную array типа массив целых чисел

        if (args.Length >= 1) // Если длина массива аргументов командной строки больше или равна единице, то выполняем следующие действия
        {
            // Преобразуем аргумент командной строки в целое число
            int length = int.Parse(args[0]); // Преобразуем первый аргумент командной строки в целое число и сохраняем его в переменную length
            array = PrimeNumbersCounter.GenerateRandomArray(length); // Создаем массив случайных чисел длиной length с помощью метода GenerateRandomArray класса PrimeNumbersCounter и сохраняем его в переменную array
        }
        else // Иначе выполняем следующие действия
        {
            array = PrimeNumbersCounter.GenerateRandomArray(10); // Создаем массив случайных чисел длиной 10 с помощью метода GenerateRandomArray класса PrimeNumbersCounter и сохраняем его в переменную array
        }

        int count; // Объявляем переменную count типа int
        List<int> primes; // Объявляем переменную primes типа List<int>
        PrimeNumbersCounter.CountPrimeNumbers(array, out count, out primes); // Вызываем метод CountPrimeNumbers класса PrimeNumbersCounter с аргументами array, count и primes, используя ключевое слово out для передачи параметров по ссылке
        PrimeNumbersCounter.PrintResult(count, primes); // Вызываем метод PrintResult класса PrimeNumbersCounter с аргументами count и primes
    }
}