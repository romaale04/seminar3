// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000)
{
    int result = number % 100;
    int secondNumber = result/10;
    System.Console.WriteLine(secondNumber);
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}
