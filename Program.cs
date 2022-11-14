// 1. Метод создания массива строк заданной длины
string[] CreateArray(int size)
{
    return new string[size];
}

// 2. Метод заполнения массива строк случайными данными 
void FillArrayStringsRandom(string[] text, string selectChar,
                            int lengthItemMin, int lengthItemMax)
{
    int size = text.Length;
    int countChars = selectChar.Length;
    int lengthItem;
    for (int i = 0; i < size; i++)
    {
        lengthItem = new Random().Next(lengthItemMin, lengthItemMax + 1);
        for (int j = 0; j < lengthItem; j++)
        {
            text[i] += selectChar[new Random().Next(0, countChars)];
        }
    }
}

// 3. Метод печати массива строк через разделитель
void PrintArrayStrings(string[] text, string separator)
{
    int size = text.Length;
    Console.Write('[');
    if (size > 0)
    {
        for (int i = 0; i < size - 1; i++)
        {
            Console.Write('"' + text[i] + '"' + separator);
        }
        Console.WriteLine('"' + text[size - 1] + '"' + ']');
    }
    else Console.WriteLine(']');
}

// 4. Метод подсчета количества элементов массива заданной длины
int CalculateCountItemsFitLength(string[] text, int maxLengthItem)
{
    int size = text.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (text[i].Length <= maxLengthItem)
            count++;
    }
    return count;
}
