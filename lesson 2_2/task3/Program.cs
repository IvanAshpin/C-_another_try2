int n = 10;
int[] array = { 1, 64, 3, 144, 6, 77, 8, 9, 6, 3 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($" {array[i]} ");
    }
    i = i + 1;
}
