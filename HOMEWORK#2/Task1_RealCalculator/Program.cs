
using System.Data.Common;

Console.WriteLine("Please enter your first number:");
bool userInputNumber1 = int.TryParse(Console.ReadLine(), out int number1);

Console.WriteLine("Please enter your second number:");
bool userInputNumber2 = int.TryParse(Console.ReadLine(), out int number2);

Console.WriteLine("Please choose operation:");
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


Console.ReadLine();