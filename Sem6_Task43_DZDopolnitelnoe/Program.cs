// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//* Найдите площадь треугольника образованного пересечением 3 прямых

//Вводим данные
double b1 = ReadData("Введите значение b1: ");
double b2 = ReadData("Введите значение b2: ");
double b3 = ReadData("Введите значение b3: ");
double k1 = ReadData("Введите значение k1: ");
double k2 = ReadData("Введите значение k2: ");
double k3 = ReadData("Введите значение k3: ");
double x = 0;
double pointX1 = PointX(b1, b2, k1, k2);
double pointX2 = PointX(b2, b3, k2, k3);
double pointX3 = PointX(b1, b3, k1, k3);
double pointY1 = PointY(b1, k1, x);
double pointY2 = PointY(b2, k2, x);
double pointY3 = PointY(b3, k3, x);
double side1 = SideOfTriangle(pointX1, pointY1, pointX2, pointY1);
double side2 = SideOfTriangle(pointX2, pointY2, pointX3, pointY3);
double side3 = SideOfTriangle(pointX1, pointY1, pointX3, pointY3);
double s = Square(side1, side2, side3);
PrintData("Площадь треугольника: " + s);
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

//Метод вычисляет точку x
double PointX(double b1, double b2, double k1, double k2)
{//Путем решения уровнения вида k1*x + b1 = k2*x + b2 вычисляем X; x = (b2 - b1)/(k1 - k2)
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

//Метод вычисляет точку y
double PointY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

//Вычисляем длинну стороны треугольника
double SideOfTriangle(double pointX1, double pointY1, double pointX2, double pointY2)
{
    double sideOfTriangle = Math.Sqrt(Math.Pow((pointX1 - pointX2), 2) + Math.Pow((pointY1 - pointY2), 2));
    return sideOfTriangle;
}

//Метод вычисляет площадь треугольника по трем сторонам
double Square(double side1, double side2, double side3)
{
    //вычисляем полупериметр
    double p = (side1 + side2 + side3) / 2;
    double s = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
    return s;
}
