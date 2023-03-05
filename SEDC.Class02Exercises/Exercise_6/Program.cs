

Console.WriteLine("Enter the First number:");
bool isFirstNumParsed = int.TryParse(Console.ReadLine(), out int inputNum1);

Console.WriteLine("Enter the Second number:");
bool isSecondNumParsed = int.TryParse(Console.ReadLine(), out int inputNum2);

if(!isFirstNumParsed || !isSecondNumParsed)
{
    Console.WriteLine("Enter valid numbers!");
}
else
{
    if(inputNum1 > inputNum2)
    {
        Console.WriteLine($"Number {inputNum1} is bigger than number {inputNum2}.");
        if (inputNum1 % 2 == 0)
        {
            Console.WriteLine($"Number {inputNum1} is even number.");
        }
        else
        {
            Console.WriteLine($"Number {inputNum1} is odd number.");
        }

        if (inputNum2 % 2 == 0)
        {
            Console.WriteLine($"Number {inputNum2} is even number.");
        }
        else
        {
            Console.WriteLine($"Number {inputNum2} is odd number.");
        }

    } 
    else if(inputNum1 < inputNum2)
    {
        Console.WriteLine($"Number {inputNum2} is bigger than number {inputNum1}.");
        if (inputNum2 % 2 == 0)
        {
            Console.WriteLine($"Number {inputNum2} is even number.");
        }
        else
        {
            Console.WriteLine($"Number {inputNum2} is odd number.");
        }

        if (inputNum1 % 2 == 0)
        {
            Console.WriteLine($"Number {inputNum1} is even number.");
        }
        else
        {
            Console.WriteLine($"Number {inputNum1} is odd number.");
        }
    }
    else 
    {
        Console.WriteLine($"Numbers {inputNum1} and {inputNum2} are equal.");
    }   
}


Console.ReadLine();