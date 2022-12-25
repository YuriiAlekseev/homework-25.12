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
    }
    
    for (int j = 1; j < rows; j++)
    {  
        array[j, rows-1] = temp;
        temp = temp + 1;
    }

    for (int i = 2 ; i < 0; i--)
    {   
        array[rows-1, i] = temp;
        temp = temp + 1;
    }
    int k = columns - 2;
    for (int j = 0; j < rows-1; j++)
    {  
        array[columns -1, k] = temp;
        k = k -1;
        temp = temp + 1;
    }
    k = rows - 2;
    for (int j = 0; j < rows-2; j++)
    {  
        array[k, 0] = temp;
        k = k -1;
        temp = temp + 1;
    }
    k = columns - 3;
    for (int j = 0; j < rows-2; j++)
    {  
        array[columns -3, k] = temp;
        k = k +1;
        temp = temp + 1;
    }
    k = columns - 2;
    for (int j = 0; j < rows-2; j++)
    {  
        array[columns -2, k] = temp;
        k = k -1;
        temp = temp + 1;
    }
    return array;
}

int [,] array = FillArray(4, 4, 00, 99);
PrintArray(array);

