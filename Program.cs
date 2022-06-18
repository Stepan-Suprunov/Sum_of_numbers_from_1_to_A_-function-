// Сумма чисел от 1 до А.

int Func(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(Func(A));