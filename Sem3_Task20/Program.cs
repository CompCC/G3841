// Задача №20 Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
//вводим координаты точек
int coorX1 = ReadData("Введие координату Х1");
int coorX2 = ReadData("Введие координату Х2");
int coorY1 = ReadData("Введие координату Y1");
int coorY2 = ReadData("Введие координату Y2");

//вычисляем длинну
double len = CalcLen(coorX1, coorX2, coorY1, coorY2);

PrintData("Расстояние м-у точками:", len);


// //Метод функционального программирования
// PrintData("Расстояние м-у точками: ", CalcLen(ReadData("Введие координату Х1"),
// ReadData("Введие координату Х2"),
// ReadData("Введие координату Y1"),
// ReadData("Введие координату Y2")));

//Метод читает данные пользователя
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
double CalcLen(int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return res;
}


