// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет;
Console.Clear();

Console.WriteLine("Введите число: ");

string insert = Console.ReadLine();
int number = int.Parse(insert)!;

if (number%2 == 0)
{
    Console.WriteLine("Данное число четное");
}
else Console.WriteLine("Данное число нечетное");