//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumb(int num)
{
    int sot = num / 10;
    int des = sot % 10;
    return des;
}
Console.WriteLine("Введите трехзначное  число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumb(num);
Console.WriteLine($"Цифра посередине: {newNum}");
*/
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int CutNumb(int num)
{
    if (num > 999)
    {
        while (num > 999) 
        {
            num = num / 10;
        }
    }    
    if (num >= 100 && num <= 999) 
        {
            num = num % 10;
            return num; 
        } 
    else
        {
            num = -1;
            return num;
        }                  
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = CutNumb(num);
if (res == -1) Console.WriteLine("Здесь нет третьей цифры((");
else Console.WriteLine($"Третья цифра: {res}");
*/
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WeekEnd(int num)
{
    if (num > 5) return true;
    return false;
}
Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = WeekEnd(num);
if (res == true) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int CutNumb(int num)
{
    while (num > 999)
    {
        if (num > 999) 
        {
            num = num / 10;
            return num;
        }
        if (num >= 100 && num <= 999) 
        {
            num = num % 10;
            return num; 
        } 
        else
        {
            num = -1;
            return num;
        }          
    }       
return num;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = CutNumb(num);
Console.WriteLine($"Третья цифра: {res}");
*/
