//Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

/*
bool Palindrom (int num)
{
    int r = 0, m = num;
    while (m != 0) 
    {
       r = r * 10 + m % 10;
       m = m / 10;
    }
    if (r == num) return true;           
    else return false;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Palindrom(num);
if (res == true) Console.WriteLine($"Да, число {num} - это палиндром!");
else Console.WriteLine($"Нет число {num} - это не палиндром!");
*/

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void Palindrom(int number)
{
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int nul = number / 10000;
        if (nul < 1 || nul > 9)
        {
            Console.WriteLine(number + " -> " + "Не пятизначное число");
        }
        else if (num1 == rev2 && num2 == rev1)
        {
            Console.WriteLine(number + " -> " + "Да, это палиндром!");
        }
        else
        {
            Console.WriteLine(number + " -> " + "Нет, это не палиндром!");
        } 
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Dist(double x1, double y1, double x2, double y2, double z1, double z2)
{
double x = x2 - x1;
double y = y2 - y1;
double z = z2 - z1;

double gip = Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2);
double result = Math.Sqrt(gip);
return result;
}

Console.Write("Введите координату Х для А: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для А: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х для B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z для B: ");
double zB = Convert.ToDouble(Console.ReadLine());


double res = Math.Round(Dist(xA, yA, xB, yB, zA, zB),2);
Console.WriteLine($"Расстояние между А и В {res}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube (int num)
{
    int count = 1;
        while (count <= num)
        {
        double cubeNum = Math.Pow(count,3);
        Console.Write(cubeNum + " ");
        count++;
        }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
*/