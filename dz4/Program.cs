﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Вывести четные числа от 1 до: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
{
    Console.Write($"{count} ");
    count = count + 2;
}