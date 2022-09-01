// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Метод1 заполнения массива рандомными числами:

// int[] CreateArray(int len)
// {
//     int[] array = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }

// // Метод 2 заполнения массива

int[] CreateArray(int len)
{
    int[] array = new int[len];
    for (int i = 1; i <= len; i++)
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        int element = Convert.ToInt32(Console.ReadLine());
        array[i - 1] = element;
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int len_array = 8;
int[] my_array = CreateArray(len_array);
Console.WriteLine($"Массив из {len_array} цифр:");
PrintArray(my_array);
