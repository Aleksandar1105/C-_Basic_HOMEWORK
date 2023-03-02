
Console.WriteLine("Input the First Number:");
bool userInputNumber1 = int.TryParse(Console.ReadLine(), out int number1);

Console.WriteLine("Input the Second Number:");
bool userInputNumber2 = int.TryParse(Console.ReadLine(), out int number2);

if(!userInputNumber1 || !userInputNumber2)
{
    Console.WriteLine("You entered invalid input. Please enter numbers!");  
}
else
{
number1 = number1 + number2;
number2 = number1 - number2;
number1 = number1 - number2;

Console.WriteLine("After swapping:");

Console.WriteLine($"First Number: {number1}");
Console.WriteLine($"Second Number: {number2}");
}





Console.ReadLine();