// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

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

// Метод поиска элемента по индексу в 2х мерном массиве
// Если заданный индекс разделить без остатка на количество столбцов получим индекс строки
// Если взять остаток от деления заданного индекса на количество столбцов получим индекс столбца
// исключение из этого метода составляют крайние правые числа , поэтому необходима проверка 

void Result(int user, int[,] array)
{
    int lenAllArray = array.GetLength(0) * array.GetLength(1);
    int iIndex = user / array.GetLength(1);
    int jIndex = user % array.GetLength(1) - 1;

    if (user > lenAllArray) Console.WriteLine($"Элемента {user} в заданном массиве нет");
    else
    {
        if (jIndex == -1)
        {
            iIndex = iIndex - 1;
            jIndex = array.GetLength(1) - 1;
        }
        Console.WriteLine($"Элементу {user} соответствует число: {array[iIndex, jIndex]}");
    }
}

Console.Write("Введите количество строк массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int widthArray = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(lenArray, widthArray);
PrintArray(myArray);

Console.Write("Введите номер элемента массива: ");
int user = Convert.ToInt32(Console.ReadLine());
Result(user, myArray);

