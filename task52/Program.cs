// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
double[] avgColumn = AverageColumn(matrix);
Console.WriteLine("Среднее арифметическое столбцов: ");
PrintArrayDouble(avgColumn);


double[] AverageColumn(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        avgArray[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return avgArray;
}

int[,] CreateMatrixRndInt(int rown, int colum, int min, int max)
{
    int[,] matrix = new int[rown, colum];
    var rnd = new Random();
    for (int i = 0; i < rown; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i],4}; ");
    }
    Console.WriteLine($"{arr[arr.Length - 1],4}]");
}
