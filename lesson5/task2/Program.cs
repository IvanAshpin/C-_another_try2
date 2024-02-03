// 2. Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int sumDiagonal(int[,] array)
{
int sum=0;
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if(i==j){sum=array[i,j]+sum;}
}
}
return sum;
}

Console.WriteLine(sumDiagonal(matrix));