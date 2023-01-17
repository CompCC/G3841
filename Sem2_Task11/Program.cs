//Задача №11  Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
System.Random newSintezator = new System.Random();
int num = newSintezator.Next(100, 1000);
int digitfirst = num / 100;
int digitLast = num % 10;
Console.WriteLine(num);
Console.WriteLine(digitfirst + " " + digitLast);