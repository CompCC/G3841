// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//приглашение на ввод первого числа
Console.Write("Введите число: ");
//считываем в переменную num типа string введеную строку
string? num = Console.ReadLine();
//проверяем, что в строке не null
if (num != null)
{
    //парсим введеные строки в целые числа
    int numInt = int.Parse(num);
    //объявляем новую строковою переменную rezult
    string rezult = string.Empty;
    for (int i = 2; i <= numInt; i = i + 2)
    {//выводим все четные числа в переменную rezult
        rezult = rezult + i + ", ";
    }
    // if (numInt % 2 == 0)
    // {
    //     rezult = rezult + numInt;
    // }
    // else
    // {
    //rezult = rezult.TrimEnd(',');
    // }
    //удаляем последние 2 символа в строке (, пробел)
    rezult = rezult.Remove(rezult.Length - 2);
    //выводим результат
    Console.WriteLine(rezult);
}