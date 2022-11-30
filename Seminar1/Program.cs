//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Клацните циферку на клавиатуре");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Клацните другую циферку");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine("max = " + num1 + " " + "min = " + num2);
}
else
Console.WriteLine("max = " + num2 + " " + "min = " + num1);
*/

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Клацните циферку на клавиатуре ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Клацните другую циферку ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Ну и крайний раз еще какую-нибудь циферку ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a) max = b;
if (c > b) max = c;

Console.WriteLine ("Из этой троицы наибольшее - " + max);



//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).





//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.