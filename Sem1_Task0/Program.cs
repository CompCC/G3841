// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на само себя)
Console.WriteLine("Введите число");
// считываем данные с консоли
string? InputNum = Console.ReadLine();
if (InputNum != null)
{
    // парсим введеное число
    int number = int.Parse(InputNum);
    // находим квадрат числа
    int result = number * number;
    // еще вариант
    //int result = (int)Math.Pow(number,2);

    // выводим данные в консоль
    Console.WriteLine(result);
}
else
{
Console.WriteLine("Вы не ввели число!");
}
// Еще один вариант
// Console.WriteLine(Math.Pow(int.Parse(InputNum, 2)));