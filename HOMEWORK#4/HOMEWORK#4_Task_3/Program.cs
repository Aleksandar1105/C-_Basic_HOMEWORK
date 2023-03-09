

Console.WriteLine("Enter number:");

bool isInputNumber = int.TryParse(Console.ReadLine(), out int inputNumber);

if (!isInputNumber)
{
    Console.WriteLine("You entered an invalid number!");
}
else
{
    int result = SumOfDigits(inputNumber);
    Console.WriteLine($"The sum of digits in the number is: {result}");
}

int SumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}