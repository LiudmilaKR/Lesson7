/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Вариант 1 с целочисленными значениями

int[,] array = GetArray(3, 4);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next();
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Вариант 2 с вещественными значениями

double[,] array = GetArray(3, 4);
PrintArray(array);

double[,] GetArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().NextDouble();
        }
    }
    return matrix;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2}  ");
        }
        Console.WriteLine();
    }
}
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 9);
PrintArray(array);
Position(array);

void Position (int[,] arr)
{
    Console.WriteLine("Введите номер строки: ");
    int i = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите номер столбца: ");
    int j = int.Parse(Console.ReadLine()!);
    if(i <= arr.GetLength(0) && j <= arr.GetLength(1)) Console.WriteLine(arr[i - 1, j - 1]);
    else Console.WriteLine("Такого числа в массиве нет");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] matrix = GetMatrix(rows, colums, 0, 9);
PrintMatrix(matrix);
AverCol(matrix);

void AverCol (int[,] matr)
{
    float[] arr = new float[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            arr[j] = arr[j] + matr[i, j];
        }
        arr[j] = arr[j] / matr.GetLength(0);
    }
    Console.WriteLine($"Среднее арифметическое каждого из стобца данного массива составляет {String.Join("; ", arr):f2}");
}

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] Matr)
{
    for (int i = 0; i < Matr.GetLength(0); i++)
    {
        for (int j = 0; j < Matr.GetLength(1); j++)
        {
            Console.Write($"{Matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

int[,,] matrix = GetMatrix(2, 2, 2, 11, 100);
PrintMatrix(matrix);

int[,,] GetMatrix(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];
    int[] collection = GetArray(m * n * l, minValue, maxValue);
    //Console.WriteLine(String.Join(" ", collection));
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = collection[4 * i + 2 * j + k];
            }
        }
    }
    return result;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

// Проверка уникальности цифр в одномерном массиве

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        int num = new Random().Next(minValue, maxValue);
        if (arr.Contains(num)) i--;
        else arr[i] = num;
    }
    return arr;
}
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

int[,] matrix = GetMatrix(15, 17);
PrintMatrix(matrix);

int[,] GetMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    int count = 0;
    int y;
    if (m % 2 == 0) y = m / 2;
    else y = m / 2 + 1;
    
    for (int x = 0; x < y; x++)
    {
        for (int j = x; j < n - x; j++)
        {
            int a = x;
            if (result[a, j] == 0)
            {
                count++;
                result[a, j] = count;
            }
            else break;
        }
        for (int i = 1 + x; i < m - x; i++)
        {
            int b = n - 1 - x;
            if (result[i, b] == 0)
            {
                count++;
                result[i, b] = count;
            }
            else break;
        }
        for (int j = n - 2 - x; j > x - 1; j--)
        {
            int c = m - 1 - x;
            if (result[c, j] == 0)
            {
                count++;
                result[c, j] = count;
            }
            else break;
        }
        for (int i = m - 2 - x; i > x; i--)
        {
            int d = x;
            if (result[i, d] == 0)
            {
                count++;
                result[i, d] = count;
            }
            else break;
        }
    }
    return result;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:D3} ");
        }
        Console.WriteLine();
    }
}
*/