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
    if (num >= 100 && num <= 999) 
    {
    int sot = num % 10;
    return sot; 
    }
    else
    {
    int sot = -1;
    return sot;
    }  
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNum = CutNumb(num);
Console.WriteLine($"Третья цифра: {newNum}");
*/
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
int CutNumb(int num)
{
    int sot = num % 10;
    int bigNum = num / 10;
    while (num > 999)
    {
        num = bigNum;
        break;
    } 
    if (num >= 100 && num <= 999) 
        {
            num = sot;
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
Console.WriteLine($"Третья цифра: {res}");

