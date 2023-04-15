// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Эта программа принимает на вход трехзначное число, на выходе показывает вторую цифру числа");
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

int GetLastDigit(int number)
{
    return ((number / 10) % 10);
}

if (number <100 || number >= 1000)
{
   Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
   Console.WriteLine($"Вторая цифра числа {number} - {GetLastDigit(number)}");
}


