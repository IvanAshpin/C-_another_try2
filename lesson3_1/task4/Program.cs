Random random = new Random();

int[] numbers = new int[200];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 200);
}

int[] arr = new int[175];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        arr[i] = 0;
    }
}

public static void printResult(int count, List<int> primes)
{
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}
