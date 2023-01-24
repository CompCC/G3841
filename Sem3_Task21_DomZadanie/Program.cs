// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Вычисляем расстояние м-у точками
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{// объявляем переменную куда будем записывать результат
    double res = 0;
    //процесс вычисления
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
    //вывод результата из метода
    return res;
}

//вводим координаты точек
int coorX1 = ReadData("Введие координату Х1");
int coorX2 = ReadData("Введие координату Х2");
int coorY1 = ReadData("Введие координату Y1");
int coorY2 = ReadData("Введие координату Y2");
int coorZ1 = ReadData("Введие координату Z1");
int coorZ2 = ReadData("Введие координату Z2");

//вычисляем длинну с помощю метода CalcLen
double len = CalcLen(coorX1, coorX2, coorY1, coorY2, coorZ1, coorZ2);
PrintData("Расстояние м-у точками:", len);
