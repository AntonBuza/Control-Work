int TextForLength(string text)
{
    System.Console.WriteLine(text);
    string message = Console.ReadLine();
    int result = Convert.ToInt32(message);
    return result;
}

string TextForArray(string text)
{
    System.Console.WriteLine(text);
    string message = Console.ReadLine();
    return message;
}
string[] Array(int length)
{
    string[] array = new string[length];
    for (int i=0; i < array.Length; i++)
    {
        array [i]= TextForArray($"Введите {i+1}-й элемент");
    }
    return array;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array [i]}"+" ");
    }
}

string[] NewArray (string[] array)
{
    string[] newarray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            newarray[count-1]=array[i];
        }
    }
    return newarray;
}

int length = TextForLength ("Введите количество элементов:");
string[] array = Array(length);
PrintArray(array);
System.Console.WriteLine();

