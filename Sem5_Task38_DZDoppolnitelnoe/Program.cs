// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу 
// между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.

int len = ReadData("Введите длинну массива: ");
int minValue = ReadData("Введите минимальное значение индекса массива: ");
int maxValue = ReadData("Введите максимальное значение индекса массива: ");
int[] arr = Gen1DArray(len, minValue, maxValue);
Print1DArr(arr);
Insert(arr);
PrintData("Сортировка методом вставки: ");
Print1DArr(arr);
Diff(arr);

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

int[] Insert(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int nextInd = arr[i];
        int pervIndex = i - 1;
        while (pervIndex >= 0 && arr[pervIndex] > nextInd)
        {
            arr[pervIndex + 1] = arr[pervIndex];
            arr[pervIndex] = nextInd;
            pervIndex--;
        }
    }
    return arr;
}

void Diff(int[] arr)
{
    int res = 0;
    if (arr[arr.Length - 1] >= 0 && arr[0] >= 0)
    {
        res = arr[arr.Length - 1] - arr[0];
    }
    else
    {
        if (arr[arr.Length - 1] < 0 && arr[0] >= 0)
        {
            res = arr[arr.Length - 1] + arr[0];
        }
        else
        {
            res = arr[arr.Length - 1] - arr[0];
        }
    }

    Console.WriteLine("Разница между последним и первым идексом массива: " + res);
}
