 string rec(int n)
 {
 if (n == 0)
   return "";
return $"{n}" + rec(n - 1);
 }

Console.Write("Введите элемент: "); 
int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(rec(n));

___________________________________________

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int q = m;

if (m > n)
{
    m = n;
    n = q;
}

PrintSumm(m, n, q = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int z = Convert.ToInt32(Console.ReadLine());
    return z;
}
__________________________________________________________

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

int functionAkkermana = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkermana} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int z = Convert.ToInt32(Console.ReadLine());
    return z;
}

