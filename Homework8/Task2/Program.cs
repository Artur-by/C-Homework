// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// Метод создания 2х мерного массива
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

// Метод вывода в консоль 2х мерного массива
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
// метод формирует список с суммами элементов строк 2х мерного массива
int[] SearchArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1}-ой строки: {sum}");
        sumArray[i] = sum;
    }
    return sumArray;
}

Console.Write("Введите количество строк массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int widthArray = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(lenArray, widthArray);
PrintArray(myArray);


int[] sumArray = SearchArray(myArray);
int min = sumArray[0];

// цикл для поиска индекса минимального элемента
int indexmin = 0;
for (int i = 1; i < sumArray.Length; i++)
{
    if (sumArray[i] < min)
    {
        min = sumArray[i];
        indexmin = i;
    }
}
Console.Write($"Номер строки с наименьшей суммой элементов: {indexmin + 1}");