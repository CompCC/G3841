//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// печать результата
void PrintRsult(string prefix)
{
    Console.WriteLine(prefix);
}

long RecPowFlow(int a, int b)
{
    if (b <= 1) return a;
    return a * RecPowFlow(a, b - 1);
}

long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    return MyPow(a, b / 2);
}