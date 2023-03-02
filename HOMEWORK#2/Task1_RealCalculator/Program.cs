
Console.WriteLine("Enter the First number:");
bool userInputNumber1 = int.TryParse(Console.ReadLine(), out int number1);

Console.WriteLine("Enter the Second number:");
bool userInputNumber2 = int.TryParse(Console.ReadLine(), out int number2);

Console.WriteLine("Enter the Operation:");
bool chooseOperator = char.TryParse(Console.ReadLine(), out char chosenOperator);


if (chosenOperator == '+'){
    int result = number1 + number2;
    Console.WriteLine("The result is: " + result);
}
else if (chosenOperator == '-'){
    int result = number1 - number2;
    Console.WriteLine("The result is: " + result);
}
else if (chosenOperator == '*')
{
    int result = number1 *number2;
    Console.WriteLine("The result is: " + result);
}
else if (chosenOperator == '/')
{
    int result = number1 / number2;
    Console.WriteLine("The result is: " + result);
}
else
{
    Console.WriteLine("You entered invalid operator. Please try againg with: +, - , * or / ");
}


Console.ReadLine();