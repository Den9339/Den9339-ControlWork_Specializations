void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива строк: ");
        array[i] = Console.ReadLine();
    }
}
string PrintArray(string[] array)
{
    string txt = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
         txt = txt + $"{array[i]}, ";
        else txt = txt + $"{array[i]}";
    }
    return txt;
}
string[] ArrayFrom0To3Chars(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            j++;
    }
    string[] newArray = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.Clear();
Console.WriteLine($"Введите размер массива строк: ");
int n = int.Parse(Console.ReadLine());
string[] array = new string[n];

FillArray(array);
Console.WriteLine();
Console.WriteLine("Изначальный массив: ");
Console.Write($"[{PrintArray(array)}]");
Console.WriteLine();
Console.WriteLine("Полученный массив: ");
Console.Write($"[{PrintArray(ArrayFrom0To3Chars(array))}]");