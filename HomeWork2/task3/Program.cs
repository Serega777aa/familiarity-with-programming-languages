int dayDigit = Convert.ToInt32(Console.ReadLine());

switch (dayDigit)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("нет"); 
        break;

    case 6:
    case 7:
        Console.WriteLine("да"); 
        break;

    default:    
        Console.WriteLine("Неизвестная операция!");
        break;

}
