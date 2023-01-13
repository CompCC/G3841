// // Напишите программу, которая будет выдавать
// // название дня недели по заданному номеру
Console.WriteLine("Введите число");
// //считываем данные с консоли
string? InputNum = Console.ReadLine();
if (InputNum != null)
// {
//     // парсим введеное число
//     int number = int.Parse(InputNum);
//     // находим квадрат числа
//     //int result = number * number;
//     int result = (int)Math.Pow(number,2);
    
//     // выводим данные в консоль
//     Console.WriteLine(result);
// }

Console.WriteLine(Math.Pow(int.Parse(InputNum, 2)));