/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

// для вещественных
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max) + Math.Round(rnd.NextDouble(), 2);
    // array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    // array[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation, 2); int deviation = 100 например
}

string PrintArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

// double Diff (double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         else if (array[i] < min) min = array[i];
//     }
//     return Math.Round(max - min, 2);
// }

// int pos = InputNum("Введите размер массива: ");
// double[] myArray = CraeteArray(pos);
// FillArray(myArray);
// PrintArray(myArray);

// double difference = Diff(myArray);
// Console.WriteLine(difference);

double Max(double[] array)
{
    double maxi = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > maxi) maxi = array[i];
    return maxi;
}

double Min(double[] array)
{
    double mini = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < mini) mini = array[i];
    return mini;
}

int size = InputNum("Введите размер массива:  ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

double[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

double res = Max(myArray) - Min(myArray);
Console.WriteLine($"Разница между макси и мини равна {res:f2}");

// для целых - работает!
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(min, max + 1);
// }

// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//         res += array[i] + " ";
//     return res;
// }

// int Max(int[] array)
// {
//     int maxi = array[0];
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > maxi) maxi = array[i];
//     return maxi;
// }

// int Min(int[] array)
// {
//     int mini = array[0];
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < mini) mini = array[i];
//     return mini;
// }

// int size = InputNum("Введите размер массива:  ");
// int minValue = InputNum("Введите минимальное значение элемента: ");
// int maxValue = InputNum("Введите максимальное значение элемента: ");

// int[] myArray = CreateArray(size);
// FillArray(myArray, minValue, maxValue);
// string txt = PrintArray(myArray);
// Console.WriteLine(txt);

// double res = Max(myArray) - Min(myArray);
// Console.WriteLine($"Разница между макси и мини равна {res}");