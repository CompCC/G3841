// Задача №16 Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

TestSQRT(num1, num2);
TestSQRT(num2, num1);

void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("Число " + j + " квадрат вотрого " + i);
    }
    else
    {
        Console.WriteLine("Число " + j + " не является квадратом вотрого " + i);
    }
}