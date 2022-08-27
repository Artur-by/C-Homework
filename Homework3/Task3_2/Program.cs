// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] A = { 3, 6, 8 };
int[] B = { 2, 1, -7 };

int Length(int x, int y)
{
    int res = x - y;
    return res * res;
}


int len = Length(A[0], B[0]);
int wid = Length(A[1], B[1]);
int lon = Length(A[2], B[2]);

double res = Math.Sqrt(len + wid + lon);

Console.Write($" расстояние между точками A и B в 3D пространстве: {Math.Round(res, 2)}");
