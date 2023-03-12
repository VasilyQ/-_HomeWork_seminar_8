// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
void PrintMatrix(int[,,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
              Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");  
            }
        }
        Console.WriteLine();
    }
}

int CheckNumber(int[,,]matrix, int number)
{
    int count = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                if(matrix[i,j,k] == number) count++;
            }
        }
    }
     return count;
}

int[,,] matrix = new int[2,2,2];
int check = 1;
int number = 0; 
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int k = 0; k < matrix.GetLength(2); k++)
        {
            while(check > 0)
            {
                number = Random.Shared.Next(10, 100);
                check = CheckNumber(matrix, number);
            }
            check = 1;
            matrix[i,j,k] = number;
        }
    }
}

PrintMatrix(matrix);