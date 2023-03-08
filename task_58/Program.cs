// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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


int[,] MultiMatrix (int[,] oneMatrix , int[,] twoMatrix)
{
    int[,] multiMatrix = new int[oneMatrix.GetLength(0), oneMatrix.GetLength(1)];

    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            multiMatrix[i, j] = oneMatrix[i, j] * twoMatrix[i, j];
        }
    }
    return multiMatrix;
}


int[,] matrixA = MatrixRandom (3, 4);
int[,] matrixB = MatrixRandom (3, 4);

PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();

Console.WriteLine("Их произведение будет равно следующему массиву:");
int[,] matrixC = MultiMatrix(matrixA, matrixB);
PrintMatrix(matrixC);