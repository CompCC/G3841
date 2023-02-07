// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countString, int countColumn)
{
    //Random numberSyntezator = new System.Random().NextDouble();
    int[,] resArray = new int[countString, countColumn];
    for (int i = 0; i < countString; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            resArray[i, j] = new Random().Next(0, 10);
        }
    }
    return resArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] resArray)
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

//метод подсчета среднеарифметичского каждого столца
double[] MeanColumn(int[,] resArray)
{
    double[] meanArr = new double[resArray.GetLength(1)]; //объявляем новый массив double т.к. результат может быть дробным
    for (int i = 0; i < resArray.GetLength(1); i++) //сначала пробегаемся по столбцам GetLength(1)
    {
        for (int j = 0; j < resArray.GetLength(0); j++) //здесь перескакиваем по строркам GetLength(0)
        {
            meanArr[i] = meanArr[i] + resArray[j, i]; //накапливаем в одномерный массив сумму столбца двумерного массива
        }
        meanArr[i] = meanArr[i] / resArray.GetLength(0); 
    }
    return meanArr;
}

// метод печати результирующего массива
void Print1DArray (double[] meanArr)
{
    for (int i = 0; i < meanArr.Length; i++)
    {
        Console.Write(meanArr[i] + "\t");
    }
}

int countString = InputNum("Введите количесво строк: ");
int countColumn = InputNum("Введите количесво столбцов: ");
int[,] resArray = FillTwoDimArray(countString, countColumn);
PrintTwoDimArray(resArray);
Console.WriteLine();
double[] meanArr = MeanColumn(resArray);
Print1DArray(meanArr);
