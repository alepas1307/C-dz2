// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер любого дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1)
{
    Console.WriteLine("ошибка");
}
if (day == 1)
{
    Console.WriteLine("понедельник - будний");
}
if (day == 2)
{
    Console.WriteLine("вторник - будний");
}
if (day == 3)
{
    Console.WriteLine("среда - будний");
}
if (day == 4)
{
    Console.WriteLine("четверг - будний");
}
if (day == 5)
{
    Console.WriteLine("пятница - будний");
}
if (day == 6)
{
    Console.WriteLine("суббота - выходной");
}
if (day == 7)
{
    Console.WriteLine("воскресенье - выходной");
}