// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// * Отсортировать массив методом пузырька
int len = ReadData("Введите длинну массива: ");
int minValue = ReadData("Введите минимальное значение индекса массива: ");
int maxValue = ReadData("Введите максимальное значение индекса массива: ");
int[] arr = Gen1DArr(len, minValue, maxValue);
Print1DArr(arr);
int s = Search(arr);
PrintData("Количесво четный чисел в массиве: " + s);

int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Вычисляем четные элементы методом деления на 2 без остатка
int Search(int[] arr)
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            s++;
        }
    }
    return s;
}
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
