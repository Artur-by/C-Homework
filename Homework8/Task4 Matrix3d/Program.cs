// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// функция создания 3х мерного массива и заполнения уникальными 2х значными цифрами
int[,,] Create3DMatrix(int lenMatrix, int widthMatrix, int heightMatrix, int[] listUnicum)
{
    int count = 0;
    // создаем 3х мерный пустой массив
    int[,,] myMatrix = new int[lenMatrix, widthMatrix, heightMatrix];
    for (int i = 0; i < lenMatrix; i++)
    {
        for (int j = 0; j < widthMatrix; j++)
        {
            for (int k = 0; k < heightMatrix; k++)
            {
                // проверка на уникальность рандомного элемента
                bool result = false;
                while (result == false)
                {
                    int number = new Random().Next(10, 100);
                    result = Unical(number, listUnicum);
                    if (result == true)
                    {
                        listUnicum[count] = number;
                        myMatrix[i, j, k] = number;
                        count++;
                    }
                }
            }
        }
    }
    return myMatrix;
}
// функция проверки на уникальность элементов
// если новый элемент есть в списке возвращаем false
bool Unical(int number, int[] unicum)
{
    for (int i = 0; i < unicum.Length; i++)
    {
        if (number == unicum[i]) return false;
    }
    return true;
}

// функция печати 3х мерного массива
void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}


Console.Write("Введите длинну массива: ");
int lenMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int widthMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int heightMatrix = Convert.ToInt32(Console.ReadLine());

// проверка на количество элементов массива
while (lenMatrix * widthMatrix * heightMatrix > 90)
{
    Console.WriteLine("Количество элементов массива превышает");
    Console.WriteLine("количество не повторяющихся двузначных чисел!");
    Console.Write("Введите новую длину массива: ");
    lenMatrix = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите новую ширину массива: ");
    widthMatrix = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите новую высоту массива: ");
    heightMatrix = Convert.ToInt32(Console.ReadLine());
}

int[] listUnicum = new int[lenMatrix * widthMatrix * heightMatrix];
int[,,] myMatrix = Create3DMatrix(lenMatrix, widthMatrix, heightMatrix, listUnicum);


Print3DMatrix(myMatrix);
