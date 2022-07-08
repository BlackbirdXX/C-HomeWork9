// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


using System;
using static System.Console;
Clear();

WriteLine("Программа, вычисления функции Аккермана с помощью рекурсии.");
WriteLine("Задайте два целых и положительных числа");
WriteLine("Введите M и N через пробел. \nПервое - M, второе - N");

string[] sizes = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(sizes[0]);
int b = int.Parse(sizes[1]);
Write($"M={a}; N={b}; ");
WriteLine($"A({a},{b}) = {Akkerman(a, b)}");

int Akkerman(int a, int b)
{
    //if (a == 0) return b + 1;
    //else if (b == 0) return Akkerman(a - 1, 1);
    //else return Akkerman(a - 1, Akkerman(a, b - 1));
    return (a == 0) ? b + 1
    : (a != 0 && b == 0) ? Akkerman(a - 1, 1)
    : (a > 0 && b > 0) ? Akkerman(a - 1, Akkerman(a, b - 1)) : a;
}