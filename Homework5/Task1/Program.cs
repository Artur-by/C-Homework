// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int len)
{
    int[] myArray = new int[len];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }
    return myArray;
}


void PrintArray(int[] array)
{
    foreach (int i in array) Console.Write($"{i}  ");
}

void EvenNumbers(int[] array)
{
    int evenCount = 0;
    foreach (var item in array)
    {
        evenCount += item % 2 == 0 ? 1 : 0;
    }
    Console.WriteLine($"Kоличество чётных чисел в массиве: {evenCount}");

}

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(len);
Console.WriteLine("Заданный массив:");
PrintArray(myArray);
Console.WriteLine();
EvenNumbers(myArray);


