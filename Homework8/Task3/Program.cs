// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// метод перемножения матриц состоит в перемножении строк со столбцами
// по алгоритму: 
// c00 = A00*B00 + A01*B10
// c01 = A00*B01 + A01*B11
// c10 = A10*B00 + A11*B10
// c11 = A10*B01 + A11*B11

// Метод создания 2х мерного массива
int[,] CreateMatrix(int lenArray, int widthArray)
{
    int[,] newArray = new int[lenArray, widthArray];
    for (int i = 0; i < lenArray; i++)
    {
        for (int j = 0; j < widthArray; j++)
        {
            newArray[i, j] = new Random().Next(0, 4);
        }
    }
    return newArray;
}

//метод вывода элементов массива в консоль
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}


// метод умножения элементов из 2х матриц

int Multiplication(int[,] matr1, int[,] matr2, int m, int n)
{
    int sum = 0;
    for (int i = 0; i < matr1.GetLength(1); i++)
    {
        sum = sum + matr1[m, i] * matr2[i, n];
    }
    return sum;

}

Console.Write("Введите число строк первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы: ");
int d = Convert.ToInt32(Console.ReadLine());


int[,] matrix1 = CreateMatrix(a, b);
int[,] matrix2 = CreateMatrix(b, d);
int[,] matrix3 = new int[a, d];

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        matrix3[i, j] = Multiplication(matrix1, matrix2, i, j);
    }
}
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);
Console.WriteLine("Матрица итоговая - перемноженная:");
PrintMatrix(matrix3);