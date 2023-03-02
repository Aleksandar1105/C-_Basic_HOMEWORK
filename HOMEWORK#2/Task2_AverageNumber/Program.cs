

Console.WriteLine("Enter the First number:");
bool userInputNumber1 = double.TryParse(Console.ReadLine(), out double number1);
//Console.WriteLine(userInputNumber1);

Console.WriteLine("Enter the Second number:");
bool userInputNumber2 = double.TryParse(Console.ReadLine(), out double number2);

Console.WriteLine("Enter the Third number:");
bool userInputNumber3 = double.TryParse(Console.ReadLine(), out double number3);

Console.WriteLine("Enter the Fourth number:");
bool userInputNumber4 = double.TryParse(Console.ReadLine(), out double number4);

double averageNumber = (number1 + number2 + number3 + number4) / 4;

if(!userInputNumber1 || !userInputNumber2 || !userInputNumber3 || !userInputNumber4)
{
    Console.WriteLine("You entered invalid input. Please enter only numbers!");
}
else
{
Console.WriteLine($"The average of {number1}, {number2}, {number3} and {number4} is: {averageNumber}");
}


Console.ReadLine(); 