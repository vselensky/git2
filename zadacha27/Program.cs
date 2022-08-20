// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int digit = (a%10);
int count = 10;
int b = 0;
while (a / count > 0)
{
    b = b + (a%10);
    a = a / 10;
}
Console.WriteLine(a + b);