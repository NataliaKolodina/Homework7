// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();
int rows = InputNum("Введите количество строк: ");
int colums = InputNum("Введите количество столбцов: ");
int x = InputNum("Введите позицию строки нужного элемента: ");
int y = InputNum("Введите позицию столбца нужного элемента: ");

int[,] arr = GetArray(rows, colums, 1, 10);
PrintArray(arr);
Element(arr, x, y);

int InputNum(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Element(int[,] array, int X, int Y)
{
    if ((X < array.GetLength(0)) && (Y < array.GetLength(1)))
    {
        Console.WriteLine($"Нужный элемент = {array[X, Y]}");
    }
    else
    {
        Console.WriteLine($"[{X}, {Y}] -> по такому индексу нет элемента.");
    }
}
