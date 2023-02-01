// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int len = ReadData("Введите длинну массива: ");
int minValue = ReadData("Введите минимальное значение индекса массива: ");
int maxValue = ReadData("Введите максимальное значение индекса массива: ");
int[] arr = Gen1DArr(len, minValue, maxValue);
Print1DArr(arr);
int s = Search(arr);
PrintData("Сумма элементов, стоящих на нечётных позициях: " + s);

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
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Поиск суммы элементов стоящих на нечетных позициях
int Search(int[] arr)
{
    int s = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        s += arr[i];
    }
    return s;
}