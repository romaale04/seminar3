// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 


Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber = 0;

if (number < 100)
{
    Console.WriteLine("В этом числе нет третьей цифры!");
}
else

while (number > 999 )
{
    number = number / 10;
}

thirdNumber = number % 10;
Console.WriteLine($"Третья цифра заданного числа: {thirdNumber}");
