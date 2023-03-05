

Console.WriteLine("Enter the whole number from 1 to 3:");
bool isValidNumber = int.TryParse(Console.ReadLine(), out int inputNumber);

if (!isValidNumber)
{
    Console.WriteLine("You entered invalid number. Enter the whole number from 1 to 3!");
}
else
{
    switch (inputNumber)
    {
        case 1:
            Console.WriteLine("You got a new car!");
            break;
        case 2:
            Console.WriteLine("You got a new plane!");
            break;
        case 3:
            Console.WriteLine("You got a new bike!");
            break;
        default:
            Console.WriteLine("Error! Something went wrong! Try again!");
            break;
    }
}



Console.ReadLine(); 