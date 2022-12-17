System.Console.Write("numbers1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("numbers2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("numbers3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c; 

System.Console.Write("max = ");
System.Console.Write(max);