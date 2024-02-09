//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int A(int m, int n)
{
    if (m == 0) return n + 1;

    else if (m > 0 && n == 0) return A(m - 1, 1);

    else return A(m - 1, A(m, n - 1));
}

Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Вывод");
Console.WriteLine(A(M, N));