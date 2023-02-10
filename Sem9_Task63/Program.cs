

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

// 1 2 3 ..... n
//num = 5 5_            5_4_3_2_1
//num = 4   4_
//num = 3     3_
//num = 2       2_
//num = 1         1_       1_""
//(return string.Empty;) num = 0 ""

string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return LineGenRec(num - 1) + " " + num;
    }
}

int number = ReadData("Введите число: ");
string resultline = LineGenRec(number);
PrintRsult(resultline);