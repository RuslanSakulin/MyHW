/*//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine()); 
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
/*//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}
int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

void ReturnNumber(int[,] array)
{
    Console.Write("Input a number of row: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of column: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a>rows || b>columns) Console.WriteLine("Числа с такими индексами не существует!");
    else
    {
        int c = array[a,b];
        Console.WriteLine($"Искомый элемент: {c}");
    }
}    
ReturnNumber(myArray);
*/
/*//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    return array;
}
void Show2dArrayAndAverage(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();    
    }
    Console.WriteLine();
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i, j]);
        }
        avarage = avarage / rows;
        Console.Write(avarage + "\t");
    }    
}
int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArrayAndAverage(myArray);
*/