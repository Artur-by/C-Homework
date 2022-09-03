// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//  Так как вещественные числа -- числа, которые обладают дробной частью.
// И Они могут быть как положительными, так и отрицательными.
// То массив задаем как double 

double[] CreateArray(int len)
{
    double[] myArray = new double[len];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-10, 10);
    }
    return myArray;
}


void PrintArray(double[] array)
{
    foreach (int i in array) Console.Write($"{i}  ");
}


void Result(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine("Разницa между максимальным и минимальным элементов массива:");
    Console.WriteLine($"{max} - {min} = {max - min}");

}


Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(len);
Console.WriteLine("Заданный массив:");
PrintArray(myArray);
Console.WriteLine();
Result(myArray);
