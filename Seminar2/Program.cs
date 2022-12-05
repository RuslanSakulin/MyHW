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

int CutNumb(int num)
{
    while (num > 999)
    int newNum = num % 10;
    return newNum;
    {
        if (num >= 100 && num <= 999) 
        {
        int newNum = num % 10;
        return newNum; 
        }
        else
        {
        int newNum = -1;
        return newNum;
        }  
    }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumb(num);
Console.WriteLine($"Третья цифра: {newNum}");

/*
if (num >= 100 && num <= 999) 
        {
        int newNum = num % 10;
        return newNum; 
        }
        else
        {
        int newNum = -1;
        return newNum;
        }   
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WeekEnd(int num)
{
    if (num > 5)
    {
    return true;
    }
    else
    {
    return false;
    }
}
Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = WeekEnd(num);
if (res == true)
{
Console.WriteLine("Yes");
}
else 
{
Console.WriteLine("No");
}
*/