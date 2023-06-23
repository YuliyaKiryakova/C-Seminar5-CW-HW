/* Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1);
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int EvenNums(int[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            index++;
    }
    return index;
}

int size = InputNum("Введите размер массива:  ");
int minValue = InputNum("Введите трехзначное минимальное число: ");
int maxValue = InputNum("Введите трехзначное максимальное число: ");

if (minValue > 99 && minValue <= 999 && maxValue > 99 && maxValue <= 999)
{
    int[] myArray = CreateArray(size);
    FillArray(myArray, minValue, maxValue);
    string txt = PrintArray(myArray);
    Console.WriteLine(txt);

    int count = EvenNums(myArray);
    Console.WriteLine($"Количество четных чисел в массиве {count}");
}
else
    Console.WriteLine("Введены не трехзначные значения элементов..");
