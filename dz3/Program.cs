﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Проверка числа на чётность. Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}