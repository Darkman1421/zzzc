//Нахождение максимума с помощью функции
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//    index=   0   1   2    3   4    5   6   7  8
int[] array = {14, 22, 3, 1114, 54, 136, 67, 8, 91};
array[0] = 12;

int max =Max(
        Max(array[0], array[1], array[2]), 
        Max(array[3], array[4], array[5]),
        Max(array[6], array[7], array[8])        
);
System.Console.WriteLine(max);