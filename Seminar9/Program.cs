/*//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
   Console.Write(num + " ");
   if(num > 1) ShowNums(num - 1);
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);
*/
/*//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int m, int n)
{
   if(m < n) return m + SumNumbers(m + 1,n);
   if(m > n) return m + SumNumbers(m - 1,n);
   return n;       
}
    
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = SumNumbers(m,n);
Console.WriteLine("Sum = " + (res));
*/
/*//Напишите программу вычисления функции Аккермана
/*
int Ack(int n, int m)
{
   if(n == 0) return m + 1;
   else 
   if(n != 0 && m == 0) return Ack(n - 1, 1);
   if(n > 0 && m > 0) return Ack(n - 1, Ack(n, m - 1));
   return Ack(n,m);       
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());    
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = Ack(m,n);
Console.WriteLine($"A({m},{n}) = {res}");
*/