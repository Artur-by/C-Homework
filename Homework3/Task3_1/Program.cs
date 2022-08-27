//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Check(int num)
{
    if (num % 10 == num / 10000 && num % 100 / 10 == number / 1000 % 10)
        return true;
    else return false;
}

bool res = Check(number);

if (res) Console.WriteLine("да, введенное число палиндром");
else Console.Write("нет, введенное число не является палиндромом");

