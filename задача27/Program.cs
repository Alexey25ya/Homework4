//  Напишите программу, которая принимает на 
//вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int sum(int n)
{
    int i = 0;
    while (n > 0)
    {
        i += n % 10;
        n /= 10;
    }
    return i;
}
Console.WriteLine(sum(N));
