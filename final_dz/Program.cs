﻿Console.Clear();
Console.Write("Задайте количество строк массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string [length];
Console.WriteLine("Введите значение строки через Enter: ");
int counter = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = Convert.ToString(Console.ReadLine());
    if(array[i].Length <= 3) counter++;
}
string[] secondArray = new string [counter];
counter = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[counter] = array[i];
        counter++;
    }
}
PrintArray(array);
Console.Write(" - ");
PrintArray(secondArray);

void PrintArray(string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
       Console.Write(array[i]  + " ");
    }
    Console.Write("]");
}