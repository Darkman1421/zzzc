Console.Write("Enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == Math.Pow(b, 2))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}