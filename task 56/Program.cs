﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
int LeastAmount(int [,] array)
{
    int [] summArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        summArray[i] = summ;
    }
    // Console.WriteLine(String.Join(" ", summArray));
    int minSummArray = summArray[0];
    int indexMinSummArray = 0;
    for (int k = 0; k < summArray.Length; k++)
    {
        if (minSummArray > summArray[k])
        {
            minSummArray = summArray[k];
            indexMinSummArray = k;
        }    
    }
    return indexMinSummArray + 1;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] FillArray(int rows, int columns, int begin, int end)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end);
        }
    }
    return array;
}

int [,] array = FillArray(9, 8, 0, 9);
PrintArray(array);
int summArray = LeastAmount(array);
Console.WriteLine();
Console.WriteLine(summArray + " строка с наименьшей суммой элементов");
