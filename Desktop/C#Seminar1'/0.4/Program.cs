//Таблица умножения
Console.WriteLine("Введите число для выведения таблицы умножения");

int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<11; i++)
{
    Console.Write(a + "*" + i + " = "); Console.WriteLine(a*i);
}