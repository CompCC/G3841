// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

////Вариант 1
// Console.WriteLine("Введите 3х значное число: ");
// string? num = Console.ReadLine();
// if (num != null)
// {
//     int length = num.ToString().Length;
//     if (length == 3)
//     {
//         int num1 = int.Parse(num);
//         int reszult = num1 % 10;
//         Console.Write("3я цифра введеного числа: " + reszult);
//         return;
//     }
//     if (length > 3)
//     {
//         int res = length - 3;
//         string digit = num.Remove(num.Length - res);
//         int rezult = int.Parse(digit);
//         rezult = rezult % 10;
//         Console.Write("3я цифра введеного числа: " + rezult);
//         return;
//     }
//     else
//     {
//         Console.WriteLine("Вы ввели число менее 3х знаков!");
//     }
// }

// //Вариант 2
// Console.WriteLine("Введите 3х значное число: ");
// char[] digit = Console.ReadLine().ToCharArray();

// if (digit.Length > 2)
// {
//     Console.WriteLine("Третья цифра введеного числа: " + digit[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет!");
// }

//Вариант 3
Console.WriteLine("Введите 3х значное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
//находим длинну введеного числа
int length = num.ToString().Length;
if (length == 3)
{
    //если длинна = 3 получаем остаток от деления на 10
    int reszult = num % 10;
    //выводим результат
    Console.Write("3я цифра введеного числа: " + reszult);
    //останавливаем программу
    return;
}
if (length > 3)
{
    //если длинна числа больше 3х, число делим на 10 в длинна -3 степени, чтобы получить 3х зеачное число
    int reszult = num / (int)Math.Pow(10, length - 3);
    reszult = reszult % 10;
    Console.Write("3я цифра введеного числа: " + reszult);
}
else
{
    //если длинна меньше 3х выводим сторку
    Console.WriteLine("Вы ввели число менее 3х знаков!");
}