// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// * Сделать оценку времени алгоритма через вещественные числа и строки

//Метод считываения данных из строки введеой пользователем и пробразование в числовую переменную
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, double msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int GenArr(int num)
{//вычисляем длинну числа и заполняем массив
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num % 10;
        num = num / 10;
    }
    //вычисляем сумму чисел в массиве
    int sum = arr.Sum();
    return sum;
}
int num = ReadData("Введите число: ");
int res = GenArr(num);
PrintData("Сумма чисел числа: ", res);
