class PrimeNumbersCounter // Объявляем класс PrimeNumbersCounter
{
    // Метод для генерации случайного массива заданной длины
    // length - длина массива
    public static int[] GenerateRandomArray(int length) // Объявляем публичный статический метод (https://learn.microsoft.com/ru-ru/dotnet/csharp/methods)
                                                        //GenerateRandomArray с аргументом length типа int и возвращающий массив целых чисел
    {
        Random random = new Random(); // Создаем объект класса Random для генерации случайных чисел
        int[] numbers = new int[length]; // Создаем массив целых чисел длиной length
        for (int i = 0; i < numbers.Length; i++) // Создаем цикл, который проходит по всем элементам массива
        {
            numbers[i] = random.Next(1, 100); // Заполняем каждый элемент массива случайным числом от 1 до 100
        }
        return numbers; // Возвращаем созданный массив
    }

    // Метод для подсчета количества простых чисел в массиве и вывода списка простых чисел
    // numbers - массив, в котором ведется подсчет
    public static void CountPrimeNumbers(int[] numbers, out int count, out List<int> primes) // Объявляем публичный статический метод CountPrimeNumbers с аргументом numbers типа массив целых чисел и двумя out-параметрами count и primes (https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/value-tuples)
    {
        count = 0; // Инициализируем переменную count нулем
        primes = new List<int>(); // Создаем новый список целых чисел primes
        for (int i = 0; i < numbers.Length; i++) // Создаем цикл, который проходит по всем элементам массива
        {
            if (IsPrime (numbers[i])) // Если текущий элемент массива является простым числом, то выполняем следующие действия
            {
                count++; // Увеличиваем счетчик простых чисел на единицу
                primes.Add(numbers[i]); // Добавляем текущее простое число в список primes
            }
        }
    
    }
}    

