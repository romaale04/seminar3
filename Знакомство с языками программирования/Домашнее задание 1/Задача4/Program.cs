// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Count = 1;

if (n < Count)

{
    Console.WriteLine("Введите положительное число больше нуля");
}

while (Count <= n)
{
    if (Count%2 == 0)    {Console.WriteLine(Count + "");}
    Count ++;
}
