void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = random.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Task54()
{
    //54.Задайте двехмерный массив.Напишите программу ,которая
    //упорадочит по убыванию элементы каждой строки двухмерного массива
    int rows = 4;
    int columns = 6;

    int[,] matrix = new int[rows, columns];

    FillArray(matrix);
    PrintArray(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < columns - j -1; k++)
            {
                if (matrix[i, k] < matrix[i, k+1])
                {
                    (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                }
            }
        }
    }
    Console.WriteLine("\nОтсортированный массив:");
    PrintArray(matrix);
}

void Task56()
{
    //Задайте прямоугольный двухмерный массив...,
    //которая будет находить строку с наименьшей суммой эллементов.
    int rows = 4;
    int columns = 6;

    int[,] matrix = new int[rows, columns];

    FillArray(matrix, 0,9);
    PrintArray(matrix);

    int min_sum = Int32.MaxValue;
    int min_index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }

        if (min_sum > sum)
        {
            min_sum = sum;
            min_index = i;
        }
        Console.WriteLine($"Сумма строки {i +1} равна {sum}");
    }
    Console.WriteLine($"Минимальная сумма равна {min_sum}. Она встроке {min_index +1}");
}
Console.Clear();
Task56();

