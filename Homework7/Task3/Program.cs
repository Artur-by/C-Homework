// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArray(int lenArray, int widthArray)
{
    int[,] newArray = new int[lenArray, widthArray];
    for (int i = 0; i < lenArray; i++)
    {
        for (int j = 0; j < widthArray; j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
    return newArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        Console.WriteLine();
        double averege = Math.Round(sum / array.GetLength(0), 2);
        Console.Write($"Среднее арифметическое {i + 1}-го столбца:  {averege}");
        sum = 0;
    }
}

Console.Write("Введите количество строк массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int widthArray = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(lenArray, widthArray);
PrintArray(myArray);
Average(myArray);