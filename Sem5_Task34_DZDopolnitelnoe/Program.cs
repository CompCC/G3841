// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// * Отсортировать массив методом пузырька
int len = ReadData("Введите длинну массива: ");
int minValue = ReadData("Введите минимальное значение индекса массива: ");
int maxValue = ReadData("Введите максимальное значение индекса массива: ");
int[] arr = Gen1DArr(len, minValue, maxValue);
Print1DArr(arr);
int[] arrBuble = new int[arr.Length];
arrBuble = arr;
arrBuble = BubbleSort(arr);
PrintData("Результат соритровки пузырьком");
Print1DArr(arrBuble);

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
int[] BubbleSort(int[] arr)
{
    int temp;
    for (int i = 0; i < arrBuble.Length; i++)
    {
        for (int j = i + 1; j < arrBuble.Length ; j++)
        {
            if (arrBuble[i] > arrBuble[j])
            {
                temp = arrBuble[j];
                arrBuble[j] = arrBuble[i];
                arrBuble[i] = temp; 
            }
        }
    }


    return arrBuble;
}
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
