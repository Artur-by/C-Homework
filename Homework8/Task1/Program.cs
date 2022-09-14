// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// метод сортировки мозволяет за 1 проход переставить местами большие значения
int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp = array[i, j];
            if (array[i, j] < array[i, j + 1])
            {
                temp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = temp;
            }
        }
    }
    return (array);
}
Console.Write("Введите количество строк массива: ");
int lenArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int widthArray = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(lenArray, widthArray);

Console.WriteLine("Исходный массив:");
PrintArray(myArray);

// для сортировки всей строки необходимо метод SortArray вызвать 
//столько раз, сколько столбцов в массиве(на один меньше)
for (int i = 0; i < myArray.GetLength(1) - 1; i++)
{
    SortArray(myArray);
}

Console.WriteLine("Отсортированный массив:");
PrintArray(myArray);