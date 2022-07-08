// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая которая выведет произведение натуральных чисел в промежутке от M до N.");
WriteLine("Задайте M и N через пробел. \nПервое - M, второе - N");

string[] sizes = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizes[0]);
int n = int.Parse(sizes[1]);
Write($"M={m}; N={n}; ");
WriteLine();
int[] rangeArray = (GetArrayFromRange(m, n));
MultiplyArray(rangeArray);

int[] GetArrayFromRange(int startRange, int endRange)
{
    int[] newArray = new int[endRange - startRange + 1];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = startRange + i;
    }
    return newArray;
}
void MultiplyArray(int[] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        result *= array[i];
    }
    WriteLine($"->{result}");
}

