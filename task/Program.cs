// Написать программу,
//  которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//   При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void CreationArray2FromArray1(string[] array1, string[] array2)
{
    int indexer = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[indexer] = array1[i];
            indexer++;
        }
    }
}
void PrintArray(string[] array)
{


    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arrayString1 = new string[7] { "Fun", "Hello", "Ok", "Sun", "World", "Class", "Smile" };
string[] arrayString2 = new string[arrayString1.Length];

CreationArray2FromArray1(arrayString1, arrayString2);
PrintArray(arrayString2);
