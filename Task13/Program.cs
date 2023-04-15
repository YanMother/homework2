// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int abc = int.Parse(Console.ReadLine()!);

if (abc < 100)
{
   Console.WriteLine($"{abc} - нет третьей цифры");
}
else
{
   while (abc >= 999)
   {
        abc /= 10;
   }
        int firstDecimalPlace = abc % 10;
    Console.WriteLine($"Третья цифра заданного числа: {firstDecimalPlace}");
}