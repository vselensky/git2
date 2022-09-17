//Метод создания массива с пользовательским вводом элементов
void Array(string[] massif)
{
    for (int countElement = 0; countElement < massif.Length; countElement++)
    {
        Console.WriteLine("Введите элемент массива:");
        massif[countElement] = Console.ReadLine();

    }


}

void CreatingNewArray(string[] massif)
{
    try
    {
        Console.WriteLine("Введите количество элементов в строке для формирования нового массива:");
        int lengthString = Convert.ToInt32(Console.ReadLine());

        string[] newMassif = new string[massif.Length];

        int countNewMassif = 0;

        for (int countMassif = 0; countMassif < massif.Length; countMassif++)
        {

            if (massif[countMassif].Length <= lengthString)
            {
                newMassif[countNewMassif] = massif[countMassif];
                countNewMassif++;

            }

        }

        Console.WriteLine("\nНовый массив");
        Console.WriteLine(string.Join(" ", newMassif));
    }
    catch (System.Exception)
    {
        Console.WriteLine("Некорректный ввод");
        CreatingNewArray(massif);
    }


}

int lengthMassif;
try
{
    Console.WriteLine("Введите количество элементов в массиве:");
    lengthMassif = Convert.ToInt32(Console.ReadLine());
}
catch (System.Exception)
{
    Console.WriteLine("Некорректный ввод");
    Console.WriteLine("\nВведите количество элементов в массиве:");
    lengthMassif = Convert.ToInt32(Console.ReadLine());
}

string[] arr = new string[lengthMassif];

Array(arr);
CreatingNewArray(arr);