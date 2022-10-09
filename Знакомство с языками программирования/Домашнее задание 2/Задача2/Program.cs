// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета.

Console.WriteLine("Программа удаляет вторую цифру любого трехзначного числа");
int randomNumber = new Random().Next(100,1000);
Console.WriteLine("Число: " + randomNumber);

int number = (randomNumber / 100) * 10 + randomNumber % 10;

    Console.WriteLine($"Число без второй цифры: {number}");