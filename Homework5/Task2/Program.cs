// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int len)
{
    int[] myArray = new int[len];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-10, 10);
    }
    return myArray;
}


void PrintArray(int[] array)
{
    foreach (int i in array) Console.Write($"{i}  ");
}

void SumEvenIndex(int[] array)
{
    int sumEven = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumEven = array[i] + sumEven;
    }
    Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {sumEven}");
}

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(len);
Console.WriteLine("Заданный массив:");
PrintArray(myArray);
Console.WriteLine();
SumEvenIndex(myArray);

