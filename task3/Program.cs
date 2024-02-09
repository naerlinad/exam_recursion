// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы

void reverseit(int[] array)
{
    if (array.Length == 0) return;
    reverseit(array[1..]);
    Console.Write($"{array[0]} ");
}

void printit(int[] array)
{
    if (array.Length == 0) return;
    Console.Write($"{array[0]} ");
    printit(array[1..]);
}

void randomiseit(int[] array)
{
    if (array.Length == 0) return;
    array[0] = new Random().Next(1, 10);
    randomiseit(array[1..]);
}

int[] an_array = { 7, 6, 8, 9, 1, 3 };
randomiseit(an_array);
printit(an_array);
Console.Write(" =>  ");
reverseit(an_array);