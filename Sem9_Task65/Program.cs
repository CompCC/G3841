//Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

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

string RecLineMN(int m, int n)
{
    if (m >= n)
    {
        return n.ToString();
    }
    else
    {
        return m + " " + RecLineMN(m + 1, n);
    }
}


int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
//<тип данных> имя_переменной = (условие)? если true<значение1>: если false<значение2> 
string res = numM < numN ? RecLineMN(numM, numN) : RecLineMN(numN, numM);
PrintRsult(res);