string[] FillStringArray(string[] arrayForFilling)
{
    for (int i = 0; i < arrayForFilling.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1}-го элемента:");
        arrayForFilling[i] = Console.ReadLine();
    }
    return arrayForFilling;
}

Console.WriteLine("Введите размер одномерного текстового массива:");
int size = Convert.ToInt32(Console.ReadLine());

string[] originalArray = new string[size];
originalArray = FillStringArray(originalArray);