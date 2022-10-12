// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Не применять строки!

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int N)
{
    if (N < 10000 || N > 99999)
    {
        System.Console.WriteLine("Введено не пятизначное число");
        return false;
    }
    return true;
}

int N = Prompt("Введите пятизначное число: ");
int OldNumber = N;
int NewNumber = 0;
if(!ValidateNumber(N))
{
    return;
}
while (N > 0)
{
    int value = N % 10;
    NewNumber = NewNumber * 10 + value;
    N = N/10;
}
if (OldNumber == NewNumber)
{
    System.Console.WriteLine("Введенное число - палиндром");
}
else
{
   System.Console.WriteLine("Введенное число - не палиндром"); 
}