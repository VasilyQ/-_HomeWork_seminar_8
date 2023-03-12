
int[,] PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]);
        }
        Console.WriteLine();
    }
    return matrix;
}
 
int[,] matrix = new int[5,5];
int length = matrix.GetLength(0);
int lengthMatrix = matrix.Length;
int i = 0;
int j = 0;
int count = 0;
int index = 0;
int countMatrix = 0;


while(countMatrix != lengthMatrix-1)
{
    while(count != 1 )
    {   
        for(; j < length-1; j++)
        {
            matrix[i,j] = 1;
            countMatrix++;
            PrintMatrix(matrix);
            Console.WriteLine();
        }
        for(; i < length-1; i++)
        {
            matrix[i,j] = 1;
            countMatrix++;
            PrintMatrix(matrix);
            Console.WriteLine();

        }
        count++;
    }
    count = 0;
    while(count != 1 )
    {
        for(; j > index; j--)
        {
            matrix[i,j] = 1;
            countMatrix++;
            PrintMatrix(matrix);
            Console.WriteLine();
        }
        for(; i > index+1; i--)
        {
            matrix[i,j] = 1;
            countMatrix++;
            PrintMatrix(matrix);
            Console.WriteLine();
        }
        count++;
    }
       length--;
        count = 0;
        index++; 
}

for(int k = 0; k < matrix.GetLength(0); k++)
{
    for(int q = 0; q < matrix.GetLength(1); q++)
    {
        if(matrix[k,q] == 0)
        {
            matrix[k,q] = 1;
        }
    }
}

PrintMatrix(matrix);