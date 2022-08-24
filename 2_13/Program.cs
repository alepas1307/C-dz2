// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int num = new Random().Next();
Console.WriteLine(num);
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.Write("Третья цифра числа равна ");
    Console.WriteLine(num.ToString()[2]);
}