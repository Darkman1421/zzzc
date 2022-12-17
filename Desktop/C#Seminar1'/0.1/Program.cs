// Определение дня недели
Console.WriteLine("Enter the day of the week: ");

int A = Convert.ToInt32(Console.ReadLine());

switch(A)
{
    // Определяем день недели с помощью switch
    case 1: 
        Console.Write("Monday");
        break;
    case 2: 
        Console.Write("Tuesday");
        break;
    case 3: 
        Console.Write("Wensday");
        break;
    case 4: 
        Console.Write("Thursday");
        break;            
    case 5: 
        Console.Write("Friday");
        break;
    case 6: 
        Console.Write("Saturday");
        break;
    case 7: 
        Console.Write("Sunday");
        break;  
    default:
        Console.Write("It's not a day of week!");
        break;          
}