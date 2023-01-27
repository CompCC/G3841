// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// * Сделать оценку времени алгоритма через вещественные числа и строки

//Метод считываения данных из строки введеой пользователем и пробразование в числовую переменную

void PrintData(string msg1, double msg2)
{
    Console.Write(msg1);
    Console.WriteLine(msg2);
}

//метод генериует массив из введеного числа и складывает все индексы массива
int GenArr(string num)
{
    int num1 = int.Parse(num);
    //вычисляем длинну числа и заполняем массив
    int[] arr = new int[num1];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num1 % 10;
        num1 = num1 / 10;
    }
    //вычисляем сумму чисел в массиве
    int sum = arr.Sum();
    return sum;
}

//метод переводит введеное число в строку и складывает каждое число в переменную total
int GenString(string num)
{
    int total = 0;
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        int.TryParse(num[i].ToString(), out sum);
        total += sum;
    }
    return total;
}
Console.WriteLine("Введите число: ");
string? num = Console.ReadLine() ?? "0";

DateTime d1 = DateTime.Now;
int res = GenArr(num);
PrintData("Сумма чисел числа (вычисление через вещественные числа): ", res);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res1 = GenString(num);
PrintData("Сумма чисел числа (вычисление через строки): ", res1);
Console.WriteLine(DateTime.Now - d2);

