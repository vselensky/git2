// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int[8];
int num = array.Length;
for(int i = 0; i < num; i++)
{
    array[i] = new Random().Next(0, 20);
    Console.Write($"{array[i]} ");
}
