

DateTime today = DateTime.Today;
Console.WriteLine($"Today is: \n{today}");
Console.WriteLine();

DateTime threeDaysFromNow = today.AddDays(3);
Console.WriteLine($"Three days from now is: \n{threeDaysFromNow}");
Console.WriteLine();

DateTime oneMonthFromNow = today.AddMonths(1);
Console.WriteLine($"One month from now is: \n{oneMonthFromNow}");
Console.WriteLine();

DateTime oneMonthAndThreeDaysFromNow = oneMonthFromNow.AddDays(3);
Console.WriteLine($"One month and three days from now is: \n{oneMonthAndThreeDaysFromNow}");
Console.WriteLine();

DateTime oneYearAndTwoMonthsAgo = today.AddYears(-1).AddMonths(-2);
Console.WriteLine($"One year and two months ago was: \n{oneYearAndTwoMonthsAgo}");
Console.WriteLine();


int currentMonth = today.Month;
Console.WriteLine("The current month is:");

switch (currentMonth)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
        default:
        Console.WriteLine("Something went wrong!");
        break;
}
Console.WriteLine();


int currentYear = today.Year;
Console.WriteLine($"The current year is: \n{currentYear}");