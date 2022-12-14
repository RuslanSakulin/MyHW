//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

int CountOfEvenNumbers(int[] array)
{
    int count = 0;
    
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count += 1;
    return count;        
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = CountOfEvenNumbers(myArray);
Console.WriteLine();
Console.WriteLine("Number of even numbers = " + result);
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

int GetSumOnOddPosition(int[] array)
{
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0)
            sum += array[i];
    return sum;        
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int result = GetSumOnOddPosition(myArray);
Console.WriteLine();
Console.WriteLine("Sum of numbers in odd position  = " + result);
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.


/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
    }
    return array; 
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

void DiffMaxMin(double[] array)
{
    double dif = 0;
    double max = array[0];
    double min = array[0];
    
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
        dif = max - min;
    }       
    Console.WriteLine($"max element ({max}) - min element ({min}) = {Math.Round(dif, 2)}"); 
}


Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
Console.WriteLine();
DiffMaxMin(myArray);
*/

// Та же задача, только с другим выводом.

/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
    }
    return array; 
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
        //Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

double DiffMaxMin(double[] array)
{
    double dif = 0;
    double max = array[0];
    double min = array[0];
    
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    dif = max - min;
    return dif;         
}


Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

double result = DiffMaxMin(myArray);
Console.WriteLine();
Console.WriteLine($"Difference between maximum and minimum elements is: {Math.Round(result, 2)}");
*/