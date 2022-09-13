// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите длину матрицы: ");
int lenMatrix = Convert.ToInt32(Console.ReadLine()); ;
Console.Write("Введите ширину матрицы: ");
int widthMatrix = Convert.ToInt32(Console.ReadLine());

double[,] CreateArray(int lenMatrix, int widthMatrix)
{
    double[,] myArray = new double[lenMatrix, widthMatrix];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = Math.Round((new Random().Next(-100, 100)) / 10.0, 2);
        }
    }
    return myArray;
}


void PrintArray(double[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}

double[,] newArray = CreateArray(lenMatrix, widthMatrix);
PrintArray(newArray);

