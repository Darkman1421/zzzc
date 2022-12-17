// Чет-Нечет
Console.Write("Введи число: ");

int N = Convert.ToInt32(Console.ReadLine());


for (int i = 2; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + "/");
    }
    else
    {
        Console.Write("Eror");
    }
    i = i + 1;
}