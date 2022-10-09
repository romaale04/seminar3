// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int Prompt(string massage)


{
    Console.WriteLine(massage);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("Нужно найти выходные дни");
int weekend = Prompt("Введите число, обозначающее день недели: ");

if (weekend > 0 & weekend < 6)
{
    Console.WriteLine("Будний день");

}

else if (weekend > 5 & weekend < 8)
{
    Console.WriteLine("Выходной день");

}

else
{
    Console.WriteLine("Введена неправильная цифра");
}
