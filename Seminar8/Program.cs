/*//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
Console.WriteLine("Original array");
Show2dArray(myArray);
void SortedArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
        }
    }
}    
SortedArray(myArray);
Console.WriteLine("Sorted array");
Show2dArray(myArray);
*/
/*//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.Write("Input a size of rectangular array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] CreateRandom2dArray(int size, int minValue, int maxValue)
{
    int[,] array = new int[size, size];
    for(int i = 0; i < size; i++)
        for(int j = 0; j < size; j++)
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
int[,] myArray = CreateRandom2dArray(size, minValue, maxValue);
Show2dArray(myArray);
void MinSumOfElementsRow(int[,] array)
{
    int minSum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];      
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"The row ({indexLine}) with the smallest sum of elements: {minSum}");
}    
MinSumOfElementsRow(myArray);
*/
/*//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.Write("Введите количество строк матрицы (А): ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы (А): ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы (В): ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы (В): ");
int columnsB = Convert.ToInt32(Console.ReadLine());
if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);
Console.WriteLine("Матрица А: ");
PrintArray(A);
Console.WriteLine("Матрица В: ");
PrintArray(B);
Console.WriteLine("Произведение матриц А и В: ");
PrintArray(GetMultiMatrix(A,B));
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}
*/
/*//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.Write("Введите размерность 1: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность 2: ");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность 3: ");
int size3 = Convert.ToInt32(Console.ReadLine());
int countNums = 89;
if (size1 * size2 * size3 > countNums)
{
    Console.Write("Невозможно задать массив!");
    return;
}
int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;
    for (int i = 0; i < values.Length; i++)
    {
        int randomId = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomId];
        values[randomId] = temp;
    }
    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}
int[,,] array = Create3DMassive(size1, size2, size3);
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
        }
        Console.WriteLine();
    }
}
*/
/*//Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int num = 1;
int i = 0;
int j = 0;
int[,] array = new int[size, size];
while (num <= size * size)
{
    array[i,j] = num;
    if (i <= j + 1 && i + j < size - 1) ++j;
    else if (i < j && i + j >= size - 1) ++i;
    else if (i >= j && i + j > size - 1) --j;
    else --i;
    ++num;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
*/