//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int ProductAB (int a, int b)
{
    int i = 0;
    int product = 1;
    while (i < b)
    {
        product = product * a;
        i++;
    }
    return product;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = ProductAB(a, b);
Console.WriteLine ($"Число {a} в степени {b} = {res}");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int num)
{
    int count = 0;
    while(num!=0)
    {
        num = num /10;
        count++;
    }
    return count;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SumNum(a);
Console.WriteLine($"Count of numbers is: {result}");


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите значение элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(" | " + array[i] + " | ");
        //Console.WriteLine($"{i + 1} элемент >> {array[i]}");
    }
}

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
ShowArray(myArray);
*/



/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
    {
        sum = sum + current;
    }
    return sum;
}
Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine($"Sum of numbers from 1 to (a) is {result}");
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

