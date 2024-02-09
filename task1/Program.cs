// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

void printnums(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        printnums(num1 + 1, num2);
    }

    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        printnums(num1 - 1, num2);
    }

    if (num1 == num2) Console.Write(num2);
}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Вывод всех натуральных чисел в промежутке от М до N");
printnums(M, N);