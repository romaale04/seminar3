// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (a > b|| a > x)
{
    Console.WriteLine($"Число {a} - max.");
}
if (b > a|| b > x)
{
    Console.WriteLine($"Число {b} - max.");
}
if (x > b|| x > a )
{
    Console.WriteLine($$"Число {x} - max.");
}
