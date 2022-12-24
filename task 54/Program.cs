// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] OrderingArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int length = array.GetLength(1);
        int temp = 0;
        for (int k = 0; k < length-1; k++)
        {
            for (int j = 0; j < length - 1; j++)
            {
                if (array[i, j+1] > array[i, j])
                { 
                    temp = array[i, j+1];
                    array[i, j+1] = array[i, j];
                    array[i, j] = temp; 
                }
            }
        }    
    }
    return array;
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

int [,] array = FillArray(9, 9, 0, 9);
PrintArray(array);
OrderingArray(array);
Console.WriteLine();
PrintArray(array);