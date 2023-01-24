// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

//Метод читает введенные данные пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат 
void PrintData(bool res)
{
    if (res == true)
    {
        Console.WriteLine("Введенное число палиндром");
    }
    else
    {
        Console.WriteLine("Введенное число не палиндром");
    }
}

//Метод сравнивает первые 2 и последние 2 разряда и выдает логический результат True/False 
bool PalinTest(int n)
{
    bool res = false;
    int d1 = ((n / 10000) % 10);
    int d2 = ((n / 1000) % 10);
    int d3 = ((n / 10) % 10);
    int d4 = n % 10;
    res = (d1 == d4) && (d2 == d3) ? true : false;
    return res;
}
//просим ввести данные от пользователя и закидывем его в метод ReadData
int num = ReadData("Введите 5-ти значное число: ");
//вызываем метод PrintData и просим вывести результат с помощю метода PalinTest
PrintData(PalinTest(num));