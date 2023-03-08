// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void CountMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = matrix.GetLength(1);
        int min = 0;

        for (int k = matrix.GetLength(1); k > 0; k--)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if(matrix[i,j] > matrix[i, j+1])
                {
                    min = matrix[i, j+1];
                    matrix[i, j+1] = matrix[i, j];
                    matrix[i,j] = min;
                }
            }
        }
    }
}


int[,] newMatrix =MatrixRandom(4,3);
PrintMatrix(newMatrix);
CountMatrix(newMatrix);
Console.WriteLine();
PrintMatrix(newMatrix);
