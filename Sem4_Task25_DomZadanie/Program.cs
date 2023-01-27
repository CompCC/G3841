// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

//* Написать калькулятор с операциями +, -, /, * и возведение в степень

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

//Метод возведения числа А в степень B 
double degree(int numberA, int numberB)
{//объявляем тип данных double чтобы исключить переполнения буфера при большом результате
    double res = Math.Pow(numberA, numberB);
    return res;
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

//Вызываем метод и получаем результат в переменную res
double res = degree(numberA, numberB);
//выводим результат
PrintData("Число А в степени B: ", res);