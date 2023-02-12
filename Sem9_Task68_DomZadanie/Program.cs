// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}


void PrintResult(int prefix)
{
    Console.Write(prefix);
}

int FAccerman(int m, int n) //метод вычисления функции Аккермана
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FAccerman(m - 1, 1);
    if (m > 0 && n > 0) return FAccerman(m - 1, FAccerman(m, n - 1));
    return FAccerman(m, n);
}

int m = ReadData("Введите значение числа M:");
int n = ReadData("Введите значение числа N:");
int a = FAccerman(m, n);
PrintResult(a);