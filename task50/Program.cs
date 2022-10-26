// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);

Console.WriteLine("Введите номер строки: ");
int rown = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

if (rown > 0 && column > 0) PrintElement(rown - 1, column - 1, matrix);
else Console.WriteLine("Заданы некорректные номера строки/столбца");


void PrintElement(int i, int j, int[,] array)
{
    if (i >= array.GetLength(0) || j >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine($"Искомый элемент -> {array[i, j]}");
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
