//Считываем данные с консоли 
string? imputNumLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(imputNumLine!=null)
{
// Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine);
// Вводим промежуточное значение
    int imputNumberC = imputNumberA*(-1);
// Выходные значения
    string outNumLine = string.Empty;
// 
    while(imputNumberC < imputNumberA)
    {
        outNumLine = outNumLine + imputNumberC + ",";
        imputNumberC = imputNumberC + 1;
    }
    outNumLine = outNumLine + imputNumberA;
    Console.WriteLine(outNumLine);
}
