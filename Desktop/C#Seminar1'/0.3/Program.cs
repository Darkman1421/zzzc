// Написать последнию цифрц трехзначного числа
 int a = Convert.ToInt32(Console.ReadLine());

int lastNumber= a % 10;

System.Console.WriteLine(lastNumber);
// Смысл в том, что берем число из остактка, после того, как поделили на 10
