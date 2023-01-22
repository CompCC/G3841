// Задача №17 Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int coorX = ReadData("Введите координату X");
int coory = ReadData("Введите координату Y");
PrintQuterTest();
//Метод читает данные пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет четверть по координатам
void PrintQuterTest()
{
    if (coorX > 0 && coory > 0) Console.WriteLine("Точка в четверти 1");
    if (coorX > 0 && coory < 0) Console.WriteLine("Точка в четверти 2");
    if (coorX < 0 && coory < 0) Console.WriteLine("Точка в четверти 3");
    if (coorX < 0 && coory > 0) Console.WriteLine("Точка в четверти 4");
}