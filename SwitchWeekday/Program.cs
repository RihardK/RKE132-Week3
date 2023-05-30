
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)
{
    case 0: Console.WriteLine("It is Sunday");
        break;
    case 1: Console.WriteLine("It is Monday");
        break;
    case 2: Console.WriteLine("It is Tuesday");
        break;
    case 3: Console.WriteLine("It is Wednesday");
        break;
    case 4: Console.WriteLine("It is Thursday");
        break;
    case 5: Console.WriteLine("It is Friday");
        break;
    case 6: Console.WriteLine("It is Sunday");
        break;
    default: Console.WriteLine("Error recognizing date format. Sorry!");
        break;
}
Console.WriteLine("Have a wonderful day!");