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

string[] CreateArrayWithShotStrings(string[] initialArray, int lengthOfElements)
{
    int length = new int();
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= lengthOfElements)
        {
            length++;
        }
    }
    string[] newArray = new string[length];
    int count = new int();
    for (int j = 0; j < initialArray.Length; j++)
    {
        if (initialArray[j].Length <= lengthOfElements)
        {
            newArray[count] = initialArray[j];
            count++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите размер одномерного текстового массива:");
int size = Convert.ToInt32(Console.ReadLine());

string[] originalArray = new string[size];
originalArray = FillStringArray(originalArray);
Console.WriteLine("Изначальный массив:");
PrintArray(originalArray);

int lengthOfElements = 3;
string[] newArray = CreateArrayWithShotStrings(originalArray, lengthOfElements);
Console.WriteLine($"Новый массив с длинной элементов не более {lengthOfElements} символов:");
PrintArray(newArray);