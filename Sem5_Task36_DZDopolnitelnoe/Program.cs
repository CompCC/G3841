//Найдите все пары в массиве и выведите пользователю

int len = ReadData("Введите длинну массива: ");
int minValue = ReadData("Введите минимальное значение индекса массива: ");
int temp = minValue - 1;
int maxValue = ReadData("Введите максимальное значение индекса массива: ");
int[] arr = Gen1DArr(len, minValue, maxValue);
Print1DArr(arr);

Search(arr);



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

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void Search(int[] arr)
{
    Console.WriteLine("Индексы пар в заданном массиве:");
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j] && temp != arr[i])
            {
                temp = j;
                Console.WriteLine("Пары " + arr[i] + arr[j] + " на позиции " + i + "," + j + "; ");
                break;
            }
        }
    }
}
