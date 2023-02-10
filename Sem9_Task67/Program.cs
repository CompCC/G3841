//Задача 67
// примает на вход число и возвращает сумму числа
// 
//сумма чисел в числе
int RecSumDig(int n)
{
    if (n <= 10) return n;
    return n % 10 + RecSumDig(n / 10);
}

int SumDig(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + n % 10;
        n = n / 10;
    }
    return res;
}