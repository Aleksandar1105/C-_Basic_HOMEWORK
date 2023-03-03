
Console.WriteLine("Enter the First number:");
bool userInputNumber1 = double.TryParse(Console.ReadLine(), out double number1);

Console.WriteLine("Enter the Second number:");
bool userInputNumber2 = double.TryParse(Console.ReadLine(), out double number2);

Console.WriteLine("Enter the Operation:");
bool chooseOperator = char.TryParse(Console.ReadLine(), out char chosenOperator);

if(!userInputNumber1 || !userInputNumber2)
{
    Console.WriteLine("You entered invalid numbers! Try again!");
    return;
}


if (chosenOperator == '+'){
    double result = number1 + number2;
    Console.WriteLine("The result is: " + result);
}
else if (chosenOperator == '-'){
    double result = number1 - number2;
    Console.WriteLine("The result is: " + result);
}
else if (chosenOperator == '*')
{
    double result = number1 *number2;
    Console.WriteLine("The result is: " + result);
}
else if (chosenOperator == '/')
{
    double result = number1 / number2;
    Console.WriteLine("The result is: " + result);
}
else
{
    Console.WriteLine("You entered invalid operator. Please try againg with: +, - , * or / ");
}


Console.ReadLine();