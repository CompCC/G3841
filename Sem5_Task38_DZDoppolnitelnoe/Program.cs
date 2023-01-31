// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу 
// между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.

void PrintData(string res)
{
    Console.WriteLine(res);
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArray(int len, int minValue, int maxValue)
{
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

int[] Insert (int[])
{
for (int i = 1; i < arr.Length; i++)
{
    int k = arr [i];
    int j = 
}
}