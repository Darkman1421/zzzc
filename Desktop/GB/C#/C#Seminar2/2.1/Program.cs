// Из двух чисел
Console.WriteLine("Enter first ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second ");
int b = int.Parse(Console.ReadLine());

int max = Math.Max(a,  b);
int min = Math.Min(a, b); 
System.Console.WriteLine($"max num - {max} , {min} - min num");