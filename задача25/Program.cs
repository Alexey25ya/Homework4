// Напишите цикл, который принимает на вход два 
//числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B");
int B = Convert.ToInt32(Console.ReadLine());
int exp(int x, int y)
{
    int n = 1;
    for (int i = 0; i < y; i++)
    {
        n = n * x;
    }
    return n;
}
Console.WriteLine(exp(A, B));