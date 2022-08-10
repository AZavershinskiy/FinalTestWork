/*
FinalTestWork
 
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Пример:
[hello 2 world =D] -> [2 =D]
*/

int size = InputInt("Введите размер массива: ");
string[] array = new string[size];

FillArray(array);
Console.Write("Начальный массив: ");
PrintArray(array);

string[] newArray = new string[NewSize(array)];
newArray = FillArrayFromArray(array, newArray);
Console.WriteLine();
Console.Write("Итоговый массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(newArray);

string[] FillArrayFromArray(string[] array, string[] newArray)
{
    int j = 0;
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
int NewSize(string[] array)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newSize++;
        }
    }
    return newSize;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void FillArray(string[] array)
{
    int elementNumber = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите текст для {elementNumber}-го элемента массива: ");
        array[i] = Console.ReadLine();
        elementNumber++;
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}