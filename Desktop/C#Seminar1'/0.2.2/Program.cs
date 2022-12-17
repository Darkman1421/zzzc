// Пробуем цикл  FOR
int a = int.Parse(Console.ReadLine());

for (int currIndex = a * -1; currIndex <= a; currIndex++)
{
    System.Console.Write(currIndex + "/");
}