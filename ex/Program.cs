﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 10;
Console.WriteLine(result);