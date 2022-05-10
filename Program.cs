string[] FillStringArray(string[] arrayForFilling)
{
    for (int i = 0; i < arrayForFilling.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1}-го элемента:");
        arrayForFilling[i] = Console.ReadLine();
    }
    return arrayForFilling;
}

void PrintArray(string[] arrayToPrinting)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrinting.Length; i++)
    {
        if (i < arrayToPrinting.Length - 1)
        {
            Console.Write($"{arrayToPrinting[i]}, ");
        }
        else
        {
            Console.Write($"{arrayToPrinting[i]}");
        }
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите размер одномерного текстового массива:");
int size = Convert.ToInt32(Console.ReadLine());

string[] originalArray = new string[size];
originalArray = FillStringArray(originalArray);
Console.WriteLine("Изначальный массив:");
PrintArray(originalArray);