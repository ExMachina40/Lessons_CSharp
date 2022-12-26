// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.Write("\nВведите натуральное число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("\nВведите степень B возведения числа A: ");
int B = Convert.ToInt32(Console.ReadLine());
int power = A;
Console.WriteLine("");

for (int i = 1; i < B; i++)
{
    power *= A;
}
Console.WriteLine($"{A} в степени {B} = {power}");
Console.WriteLine();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Задача 27");
Console.Write("\nВведите натуральное число N: ");
long number = Convert.ToInt64(Console.ReadLine());
int sum = 0;
int digits = (int)Math.Log(number, 10) + 1;
Console.WriteLine($"number = {number}, digits = {digits}\n");
int dig;
for (int i = 1; i < digits+1; i++)
{
    dig = (int)(number % Math.Pow(10, i) / Math.Pow(10, i - 1));

    Console.WriteLine($"number[{i - 1}] = {dig}");
    sum += dig;
}
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");
Console.WriteLine();

// Задача 29: Напишите программу, которая задаёт массив из N элементов
// (из диапазона [0-14] ) и выводит на экран десятичное представление
// числа, записанного в СС по основанию 15

Console.WriteLine("Задача 29");
 Console.WriteLine(MyLibrary1.InFifteenth(new int[] {9, 4 ,12}));
Console.WriteLine();
