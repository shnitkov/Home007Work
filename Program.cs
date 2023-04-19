// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

String day1 = "Понедельник, опять на работу.";
String day2 = "Вторник, опять на работу.";
string day3 = "Среда, опять на работу.";
string day4 = "Четверг, опять на работу.";
string day5 = "Пятница, опять на работу.";
string day6 = "Суббота, выходной!";
string day7 = "Воскресенье, выходной!";
int Day = int.Parse(Console.ReadLine());
if (Day == 1)
{
    Console.WriteLine(day1);
}
else if (Day == 2)
{
    Console.WriteLine(day2);
}
else if (Day == 3)
{
    Console.WriteLine(day3);
}
else if (Day == 4)
{
    Console.WriteLine(day4);
}
else if (Day == 5)
{
    Console.WriteLine(day5);
}
else if (Day == 6)
{
    Console.WriteLine(day6);
}
else if (Day == 7)
{
    Console.WriteLine(day7);
}
else
{
    Console.WriteLine("Это не день недели.");
}