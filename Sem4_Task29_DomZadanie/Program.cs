// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// * Ввести с клавиатуры длину массива и диапазон значений элементов
// Дополнительно: Написать программу которая из имен через запятую выберет случайное имя 
// и выведет в терминал Игорь, Антон, Сергей -> Антон 
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//метод генерируем массив mas и заполняет его случайными значениями в соответствии с заданными параметрми begin и end
int[] GenArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(begin, end);
    }
    return mas;
}
//метод печатает в стрку массив mas
void PrintArr(int[] mas)
{
    Console.Write("[ ");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write(mas[i] + ", ");
    }
    Console.Write(mas[mas.Length - 1] + " ]");
}

int masLen = ReadData("Введите размер массива: ");
int begin = ReadData("Введите цифру начала дапазона случайных чисел: ");
int end = ReadData("Введите цифру конца дапазона случайных чисел: ");
int[] arr = GenArr(masLen, begin, end);
PrintArr(arr);