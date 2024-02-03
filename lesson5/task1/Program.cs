// 1. Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rowCount, int columsCount) // Функция создания матрицы с элементами от 1 до 999
{
int[,] matrix = new int[rowCount, columsCount];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(1, 11);
}
}
return matrix;
}

void ShowMatrix(int[,] matrix) // Функция вывода матрицы на экран
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j]} ");
}
Console.WriteLine();
}
}

int[,] matrix = CreateMatrix(3, 4); // Задание размера матрицы и инициализация "интересного" числа.
ShowMatrix(matrix);

void evenIndex(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i+=2)
{
for (int j = 0; j < array.GetLength(1); j+=2)
{
array[i, j] = array[i, j] * array[i, j];
}
}
}
evenIndex(matrix);
ShowMatrix(matrix);