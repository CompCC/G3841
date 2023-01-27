// Задача 25: 

//* Написать калькулятор с операциями +, -, /, * и возведение в степень

//Метод считываения данных из строки введеой пользователем и пробразование в числовую переменную
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, double msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

//метод суммирования
double sum(double numberA, double numberB)
{
    double res = numberA + numberB;
    return res;
}

//метод вычитания
double subtract(double numberA, double numberB)
{
    double res = numberA - numberB;
    return res;
}

//метод умножения
double multiplication(double numberA, double numberB)
{
    double res = numberA * numberB;
    return res;
}

//метод деления
double split(double numberA, double numberB)
{
    double res = numberA / numberB;
    return res;
}

//Метод возведения в степень
double degree(double numberA, double numberB)
{//объявляем тип данных double чтобы исключить переполнения буфера при большом результате
    double res = Math.Pow(numberA, numberB);
    return res;
}

double numberA = ReadData("Введите число A: ");
double numberB = ReadData("Введите число B: ");
Console.WriteLine("Введите знак действия(+, -, *, /, ^): ");
string? symbol = Console.ReadLine()?? "0";
//оределяем какое действие необходимо провести над числами с вызыванием соответствующего метода
if (symbol == "+")
{
    double res = sum(numberA, numberB);
    PrintData("Результат: ", res);
}
else if (symbol == "-")
{
    double res = subtract(numberA, numberB);
    PrintData("Результат: ", res);
}
else if (symbol == "*")
{
    double res = multiplication(numberA, numberB);
    PrintData("Результат: ", res);
}
else if (symbol == "/")
{
    double res = split(numberA, numberB);
    PrintData("Результат: ", res);
}
else if (symbol == "^")
{
    double res = degree(numberA, numberB);
    PrintData("Результат: ", res);
}
else
{
    Console.WriteLine("Вы не корректно ввели знак действия");
}