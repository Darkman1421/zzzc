// Показываем все целые числа в промежутке от -N до N
Console.WriteLine("Enter a number: ");

int A = Convert.ToInt32(Console.ReadLine());

int index = A * -1;
while(index <= A)
{
    System.Console.Write( index);
    index++;
}