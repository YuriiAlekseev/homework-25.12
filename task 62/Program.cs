// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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
    int temp = 00;
    for (int i = 0; i < rows; i++)
    {   
        array[0, i] = temp;
        temp = temp +1;
        Console.WriteLine(temp);
    }
    
    for (int j = 1; j < rows; j++)
    {  
        array[j, rows-1] = temp;
        temp = temp + 1;
        Console.WriteLine(temp);
    }

    for (int i = 2 ; i < 0; i--)
    {   
        array[3, i] = temp;
        temp = temp + 1;
        Console.WriteLine(temp);
    }

    return array;
}

int [,] array = FillArray(4, 4, 00, 99);
PrintArray(array);

