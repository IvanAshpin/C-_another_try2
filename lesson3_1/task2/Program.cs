//int n = 5;

//int i = 1;
//while (i <= n)
//{
//    Console.Write($"{i * i} ");
//    i = i + 1;
//}

//int n = 10;

//int i = 1;
//while (i <= n)
//{
//    Console.Write($"{i * i} ");
//    i = i + 1;
//}

//int n = 15;

//int i = 1;
//while (i <= n)
//{
//    Console.Write($"{i * i} ");
//    i = i + 1;
//} 


void PrintSqueras(int limit)
{
    int i = 1;
    while(i <= limit)
    {
      Console.Write($"{i * i} ");
    i++; //i = i + 1;  
    }
}
PrintSqueras(5);
PrintSqueras(10);
PrintSqueras(15);