// Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 1");
int a = new Random().Next(1, 10);
Console.WriteLine(a);
int b = new Random().Next(1, 10);
Console.WriteLine(b);
int c = new Random().Next(1, 10);
Console.WriteLine(c);

Console.WriteLine(a > b & a > c ? $"Max a = {a}" : c > b & c > a ? $"Max c = {c}" : $"Max b = {b}" );
Console.WriteLine();
// Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
//-3 -> нет
// 7 -> нет

Console.WriteLine("Задача 2");
int d = new Random().Next(1, 10);
Console.WriteLine(d);
Console.WriteLine(d % 2 == 0 ? $"Число d = {d} чётное" : $"Число d = {d} нечётное");
Console.WriteLine();

// Задача 3: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 3");
// Console.WriteLine("Введите число N");
int N = new Random().Next(1, 20); // Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Чётные числа от 1 до N = {N} :");
for (int i = 2; i <= N; i+=2)
{
    Console.WriteLine(i);
}