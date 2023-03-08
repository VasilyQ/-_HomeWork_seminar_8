// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] MatrixRandom (int n, int m)
{
    int[,] matrix = new int[n , m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


void SumMatrix (int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
            array[i] = sum;
        }
    }
    int count = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) { min = array[i]; count = i;}
    }
    
    Console.WriteLine($"{count+1} строка -> {min}");
}



int[,] matrix = MatrixRandom (4, 4);
PrintMatrix(matrix);
Console.WriteLine();
SumMatrix (matrix);