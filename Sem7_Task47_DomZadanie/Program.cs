// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countString, int countColumn)
{
    //Random numberSyntezator = new System.Random().NextDouble();
    double[,] resArray = new double[countString, countColumn];
    for (int i = 0; i < countString; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            resArray[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return resArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(double[,] resArray)
{
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            Console.Write(resArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int countString = InputNum("Введите количесво строк: ");
int countColumn = InputNum("Введите количесво столбцов: ");
double[,] resArray = FillTwoDimArray(countString, countColumn);
PrintTwoDimArray(resArray);