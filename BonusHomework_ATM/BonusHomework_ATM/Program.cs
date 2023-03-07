

double balance = 10000;
bool continueProgram = true;
bool isContinue;

do
{
    Console.WriteLine("Please select an option:");
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Withdraw money");

    bool isInputOption = int.TryParse(Console.ReadLine(), out int inputOption);

    if (isInputOption)
    {
        switch (inputOption)
        {
            case 1:
                Console.WriteLine("You have {0:C2} on your account.", balance);
                Console.WriteLine();
                break;

            case 2:
                double amount;

                Console.Write("Please enter the amount you want to withdraw: ");
                bool success = double.TryParse(Console.ReadLine(), out amount);

                if (success && amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine("You have successfully withdrawn {0:C2} and you left {1:C2} on your account.", amount, balance);
                    Console.WriteLine();
                }
                else if (success && amount > balance)
                {
                    Console.WriteLine("You cannot withdraw {0:C2} because your balance is {1:C2}. Please try again with appropriate amount!", amount, balance);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid amount entered. Please try again.");
                }

                break;

            default:
                Console.WriteLine("Invalid option selected. Please try again.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Something went wrong! Please try again!");
        Console.WriteLine();

    }

    bool continueIfWrong = true;

    while (continueIfWrong)
    {
        Console.WriteLine("Do you want to take some other actions? (Y / N):");
        isContinue = char.TryParse(Console.ReadLine().ToLower(), out char continueAction);
        if (isContinue)
        {
            if (continueAction == 'y')
            {
                continueProgram = true;
                continueIfWrong = false;
            }
            else if (continueAction == 'n')
            {
                continueProgram = false;
                continueIfWrong = true;
            }
            else
            {
                Console.WriteLine("Invalid input!!");
                continueProgram = true;
                continueIfWrong = true;
            }
        }
        else
        {
            Console.WriteLine("Invalid input!!");
        }
    }

} while (continueProgram);