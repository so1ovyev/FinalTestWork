//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] array = InputArray();
string[] newarray = LengthCheck(array);
PrintNewArray(newarray);

string[] InputArray()
{
    Console.Write("Enter number of lines: ");
    int length = int.Parse(Console.ReadLine());
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Input {i + 1} string: ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("Entered the following lines:");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
    return array;
}

string[] LengthCheck(string[] array)
{
    string[] newarray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[i] = array[i];
        }
    }
    return newarray;
}

void PrintNewArray(string[] newarray)
{
    Console.WriteLine();
    Console.WriteLine("Elements <= length 3:");
    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] != null) Console.Write($"'{newarray[i]}' ");
    }
}