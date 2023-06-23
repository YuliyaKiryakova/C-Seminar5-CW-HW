/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

bool FindNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num)
            return true;
    return false;
}

int num = InputNum("Введите число: ");
int[] newArray = new int[10];

FillArray(newArray);
PrintArray(newArray);
Console.WriteLine(FindNum(newArray, num));
