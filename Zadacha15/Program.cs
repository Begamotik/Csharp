//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int InputIntNumber()

Console.Write("Введите номер дня недели:");

int number = int.Parse(Console.ReadLine() ?? "0");
return number;

int num = InputIntNumber();
if (num >=1 && num <=5)
{
Console.WriteLine("Это будний день");
}
else if (num == 6 || num == 7)
{
Console.WriteLine("Это выходной");
}
else
{
Console.WriteLine("Введите значение от 1 до 7");
}
