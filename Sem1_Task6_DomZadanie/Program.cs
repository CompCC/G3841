﻿// №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).
//приглашение на ввод первого числа
Console.Write("Введите число: ");
//считываем в переменную num типа string введеную строку
string? num = Console.ReadLine();
if(num != null)
{
//парсим введеные строки в целые числа
int numInt = int.Parse(num);
if (numInt % 2 == 0)
{//если остаток от деления на 2, 0 то число четное
    Console.WriteLine("Введеное число четное.");
}
else
{//если есть остатое от деления на 2 то число не четное
    Console.WriteLine("Введеное число нечетное.");
}
}