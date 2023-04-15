// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int daynumber = 6;

if (daynumber >= 1 && daynumber <= 5)
{
   Console.WriteLine("Под цифрой "+ daynumber +" - Рабочий");
}
else if (daynumber >= 6 && daynumber <= 7)
{
   Console.WriteLine("Под цифрой "+ daynumber +" - Выходной");
}
else
{
   Console.WriteLine("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}