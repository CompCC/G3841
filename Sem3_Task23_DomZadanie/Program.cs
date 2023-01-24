// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом
// Читаем данные пользоваеля
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//с помощю метода печатаем результат
void PrintData(string up, string down)
{
    Console.WriteLine(up);
    Console.WriteLine(down);
}
//метод построения 2х строчек результата
string LineBuilder(int n, int p)
{
    //объявляем пустую строку куда будем накапливать результаты работы цикла for
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        //вычисляем степень от 1 до введеного пользователем числа n
        s += Math.Pow(i, p).ToString() + "\t";
    }
    return s;
}

int n = ReadData("Введите чило N: ");
//вводим данные в метод LineBuilder, сначала первой сточки
string up = LineBuilder(n, 1);
//затем второй в кубе
string down = LineBuilder(n, 3);
//выводим результат на консоль
PrintData(up, down);
