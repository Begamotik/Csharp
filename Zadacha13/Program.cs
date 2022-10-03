//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели:");
int number = Input();
if (number >=1 && number <=5)
{
Console.WriteLine($"{DayWeek(number)}!Это будний день");
}
else if (number == 6 || number == 7)
{
Console.WriteLine($"{DayWeek(number)}!Это выходной");
}
else
{
Console.WriteLine("Введите значение от 1 до 7");
}