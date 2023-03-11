

int inputNumber;
string myString = "Hello from SEDC Codecademy 2023";

Console.WriteLine($"Please enter a number:");
bool isNumber = int.TryParse(Console.ReadLine(), out inputNumber);

void Substrings(int number)
{
    if (!isNumber)
    {
        Console.WriteLine($"Invalid input! Please enter number lower than {myString.Length}");
    }
    else
    {
        if (number < myString.Length)
        {
            Console.WriteLine($"The first {number} characters from the strings are:");
            string subString = myString.Substring(0, number);
            Console.WriteLine(subString);
            Console.WriteLine(@$"The new string ""subString"" has {subString.Length} characters");
        }
        else if(number == myString.Length)
        {
            Console.WriteLine($"The string has {number} and it is the same with the number you entered!" +
                $"\nPlease enter lower number!");
        }
        else
        {
            Console.WriteLine($"The number you entered is higher than the length of the string! \nTry with number lower than {myString.Length}!");
        }
    }
}

Substrings(inputNumber);