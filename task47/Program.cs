// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

double[,] array2D = CreateMatrixRndDouble(3, 4, -10, 10);
PrintMatrixDouble(array2D);


double[,] CreateMatrixRndDouble(int rown, int colum, int min, int max)
{
    double[,] matrix = new double[rown, colum];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double number = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(number, 2);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}