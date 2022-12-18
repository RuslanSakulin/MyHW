//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int CountNumb(int num)
{
    int count = 0;
    for(int current = 1; current <= num; current++)
    {
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a > 0) count++;
    }
    return count;
}
Console.WriteLine("Введите количество чисел: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = CountNumb(a);
Console.WriteLine($"Количество чисел больше 0: {result}");
*/

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if(b1 == b2 && b1 == b2) Console.WriteLine("Эти прямые совпадают!");
else if (k1 == k2) Console.WriteLine("Эти прямые параллельны!");
else 
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Эти прямые пересекутся в точке с координатами X: {Math.Round(x, 4)}, Y: {Math.Round(y, 4)}");
}
*/

