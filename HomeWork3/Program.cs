// Задача 19 Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Задача 19");
int number = 0;
while (number < 10000 | number > 99999) 
{
    Console.Write("Введите пятизначное число:");
    number = Convert.ToInt32(Console.ReadLine());
}
int fiftForth = number/1000;
int firstSecond = (number%10)*10 + (number%100)/10;
    Console.WriteLine(fiftForth == firstSecond ? "палиндром" : "не палиндром");
Console.WriteLine();

// Задача 21 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Задача 21");
Double x1, x2, y1, y2, z1, z2, distance;
Console.Write("Введите координаты x1: ");
    x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты x2: ");
    x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y1: ");
    y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координаты y2: ");
    y2 = Convert.ToDouble(Console.ReadLine());

    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
Console.WriteLine();

// Задача 23 Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Задача 23");
Console.Write("\nВведите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for (int i = 1; i <= N; i++)
{
    Console.Write("   " + i + "\t");
}
Console.WriteLine("");
for (int i = 1; i <= N; i++)
{
    Console.Write("   " + i*i*i + "\t");
}
Console.WriteLine();