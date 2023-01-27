// Дополнительно: Написать программу которая из имен через запятую выберет случайное имя 
// и выведет в терминал Игорь, Антон, Сергей -> Антон 
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).
//Выводим приглашение и запоминаем в строку text
Console.Write("Введите имена через ',': ");
string text = Console.ReadLine() ?? "0";
//создаем массив worlds из строки text ориентиром служит знак "," параметр StringSplitOptions.RemoveEmptyEntries говорит, что
//нужно удалить все пустые подстроки если в строке будут пробелы
string[] worlds = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
Console.Write("Случайное имя: ");
//выводим значение случайного индекса массива с помощю метода Random
Console.WriteLine(worlds[new Random().Next(1, worlds.Length + 1)]);




