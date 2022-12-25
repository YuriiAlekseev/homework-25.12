// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ProductOfArrays(int [,] array, int [,] array2)
{
    Console.WriteLine("Результирующая матрица будет:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[i,j] * array2[i,j];
            Console.Write(temp + " ");

        }
        Console.WriteLine();
        
    }           
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
int [,] array2 = FillArray(9, 9, 0, 9);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
ProductOfArrays(array, array2);
