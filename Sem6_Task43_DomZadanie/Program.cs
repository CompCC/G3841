// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Вводим данные
double b1 = ReadData("Введите значение b1: ");
double b2 = ReadData("Введите значение b2: ");
double k1 = ReadData("Введите значение k1: ");
double k2 = ReadData("Введите значение k2: ");
//вычисляем координаты x и y
double x = PointX(b1, b2, k1, k2);
double y = PointY(b1, k1, x);

//Печатаем результат
PrintData("Точка пересечения прямых: (x:" + x + "; y:" + y + ")");

//Метод считывает данные
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод вычисляет точку пересечения x
double PointX(double b1, double b2, double k1, double k2)
{//Путем решения уровнения вида k1*x + b1 = k2*x + b2 вычисляем x; x = (b2 - b1)/(k1 - k2)
    double res = (b2 - b1) / (k1 - k2);
    return res;
}
//Метод вычисляет точку пересечения y
double PointY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}