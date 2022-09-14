//          Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомндуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.
//         Решение:

string[] GetArrayStringConsole (string inConsolSimvol)
{
    string[] arraySimvol = new string[inConsolSimvol.Length];
    arraySimvol = inConsolSimvol.Split(",");
    return arraySimvol;
}



void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите набор символов через знак (,) - ");
string inStringSimvol = Console.ReadLine();
Console.Write("Введенные символы - ");
Print(GetArrayStringConsole(inStringSimvol));
