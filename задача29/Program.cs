// Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
void FillArray(int[] collect)
{
    int length = collect.Length;
    for (int i = 0; i < length; i++)
    {
        collect[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] col)
{
    int l = col.Length;
    for (int i1 = 0; i1 < l; i1++)
    {
        Console.Write(col[i1]+" ");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);