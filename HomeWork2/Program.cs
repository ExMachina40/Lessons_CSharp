// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.

Console.WriteLine("Задача 10");
int a = new Random().Next(100, 999);
Console.WriteLine(a);
Console.WriteLine((a / 10) % 10);
Console.WriteLine();


// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Задача 13");
int b = new Random().Next(1, 9999);
Console.WriteLine(b);
if (b < 100)
    {
        Console.WriteLine("Третьего числа нет!");
    }
    else
    {
        Console.WriteLine((b / 100) % 10);
    }
Console.WriteLine();

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Задача 13");
int weekDay = -1;
while (weekDay < 1 | weekDay >7)
{
Console.Write("\nВведите номер дня недели от 1 (пнд) до 7 (воскр): "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
weekDay = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int
}
Console.WriteLine(weekDay == 6 | weekDay == 7 ? "Выходной\n" : "Рабочий день\n");