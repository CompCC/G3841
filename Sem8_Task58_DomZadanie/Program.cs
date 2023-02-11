// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arrA = { { 2, 4 }, { 3, 2 } };// заданы матрицы
int[,] arrB = { { 3, 4 }, { 3, 3 } };

int[,] resArr = new int[arrA.GetLength(0), arrB.GetLength(1)]; //объявляем результирующую матрицу
int[,] CompozitionArr(int[,] arrA, int[,] arrB)
{
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                resArr[i, j] += arrA[i, k] * arrB[k, j]; //вычисляем по формуле resArr[0,0] = arrA[0,0]*arrB[0,0]+ arrA[0,1]*arrB[1,0]
            }
        }
    }
    return resArr;
}

// Печать двумерного массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Результат призведения 2х матриц: ");
resArr = CompozitionArr(arrA,arrB);
Print2DArr(resArr);