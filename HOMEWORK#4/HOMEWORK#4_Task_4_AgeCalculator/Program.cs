

Console.WriteLine("Enter your birthday in format (yyyy, mm, dd):");
bool isMyBirthday = DateTime.TryParse(Console.ReadLine(), out DateTime myBirthday);

if (!isMyBirthday)
{
    Console.WriteLine("You entered invalid input!");
}
else
{
    int myAge = AgeCalculator(myBirthday);
    Console.WriteLine($"Your age is: {myAge}");
}

int AgeCalculator(DateTime myBirthday)
{
    DateTime today = DateTime.Today;
    int myAge = today.Year - myBirthday.Year;

    if (myBirthday > today.AddYears(-myAge))
    {
        myAge--;
    }
    return myAge;
}

