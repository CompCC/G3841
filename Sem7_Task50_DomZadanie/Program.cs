// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//метод принимает данные
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод генерации массива
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

//Метод поиска индекса по введенным данным
void SerchElem(int[,] arr, int line, int colum)
{
    if (line < arr.GetLength(0))
    {
        if (colum < arr.GetLength(1))
        {
            int res = arr[line, colum];
            Console.WriteLine("Введенный индекс " + line + colum + " равен значению " + res);
        }
    }
    else
    {
        Console.WriteLine("Введенного индекса " + line + colum + " в массиве нет!");
    }
}

int countString = InputNum("Введите количесво строк: ");
int countColumn = InputNum("Введите количесво столбцов: ");
int line = InputNum("Введите индекс строки: ");
int colum = InputNum("Введите индекс столбца: ");
int[,] resArray = FillTwoDimArray(countString, countColumn);
PrintTwoDimArray(resArray);
SerchElem(resArray, line, colum);