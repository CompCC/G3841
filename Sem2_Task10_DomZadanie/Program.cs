﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//вывод пришлашения
Console.Write("Введите число: ");
//парсим сторку в численное значение
int num = int.Parse(Console.ReadLine() ?? "0");
//вычисляем днинну сторки
int length = num.ToString().Length;
//проверяем, что число 3х значное
if (length == 3)
{
    //убираем последнюю цифру
    int res = num / 10;
    //находим остаток от деления 2х значного числа
    res = res % 10;
    //выводим результат
    Console.WriteLine("Вторая цифра введеного числа: " + res);
}
else
{
    Console.WriteLine("Вы не ввели 3х значное число!");
}