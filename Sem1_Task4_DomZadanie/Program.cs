// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.
//приглашение на ввод первого числа
Console.Write("Введите первое число: ");
//считываем в переменную num1 типа string введеную строку
string? num1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? num2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string? num3 = Console.ReadLine();
if (num1 != null && num2 != null && num3 != null)
{
    //парсим введеные строки в целые числа
    int numInt1 = int.Parse(num1);
    int numInt2 = int.Parse(num2);
    int numInt3 = int.Parse(num3);
    //сравниваем первое и второе число
    if (numInt1 > numInt2)
    {
        //если первое больше сравниваем первое и третье
        if (numInt1 > numInt3)
        {
            //если первое больше выводим первое число как ответ
            Console.Write("Максимальное число: ");
            Console.WriteLine(numInt1);
        }
    }
    else
    { //если первое не больше сравниваем второе и третье числа
        if (numInt2 > numInt3)
        {// если не равенство верно, выводим второе число
            Console.Write("Максимальное число: ");
            Console.WriteLine(numInt2);
        }

        else
        {// если не верно, выводим третье число
            Console.Write("Максимальное число: ");
            Console.WriteLine(numInt3);
        }
    }
}
