//Метод читает данные пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
// вывод нахождения степени чисел от 1 до N
string LineBilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t";
    }
    return s;
}

//Ввод данных
int num = ReadData("Введите N: ");

//Собираем первую строчку таблицы
string line1 = LineBilder(num, 1);
//Собираем вторую строчку таблицы
string line2 = LineBilder(num, 2);

// Вывод данных
PrintData(line1, line2);