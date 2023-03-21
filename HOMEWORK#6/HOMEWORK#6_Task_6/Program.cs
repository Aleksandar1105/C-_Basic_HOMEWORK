

using HOMEWORK_6_Task_6.Models;
using System.Threading.Tasks;

Customer customer1 = new Customer("Aleksandar", "Todoroski", 50000, 1285522466384785, 4582);
Customer customer2 = new Customer("Goran", "Trpkovski", 65000, 5224696844528854, 1232);
Customer customer3 = new Customer("Nadica", "Ugrova", 70000, 1322457488256645, 3236);

Customer[] customers = new[] { customer1, customer2, customer3 };

bool exitApp = true;

while (exitApp)
{
    Console.WriteLine("Welcome to the ATM app");
    Console.WriteLine("Please enter your card number in format XXXX-XXXX-XXXX-XXXX: ");
    string cardNumberInput = Console.ReadLine();
    string cardNumberInputWithoutDashes = cardNumberInput.Replace("-", "");
    bool isValidCardNumber = long.TryParse(cardNumberInputWithoutDashes, out long cardNumber);

    if (isValidCardNumber)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (cardNumber == customers[i].CardNumber)
            {
                Console.WriteLine("Enter pin: ");
                bool isPinParsed = int.TryParse(Console.ReadLine(), out int pin);

                if (isPinParsed)
                {
                    if (customers[i].IsPinValid(pin))
                    {
                        Console.WriteLine($"Welcome {customers[i].FirstName} {customers[i].LastName}!");

                        bool newTransaction = true;
                        while (newTransaction)
                        {
                            Console.WriteLine("What would you like to do: ");
                            Console.WriteLine();
                            Console.WriteLine("1. Check Balance");
                            Console.WriteLine("2. Cash Withdrawal");
                            Console.WriteLine("3. Cash Deposit");
                            Console.WriteLine("4. Exit");
                            bool isOptionParsed = int.TryParse(Console.ReadLine(), out int optionInput);

                            if (!isOptionParsed)
                            {
                                Console.WriteLine("Wrong input!");
                            }
                            else
                            {
                                switch (optionInput)
                                {
                                    case 1:
                                        Console.WriteLine("You have {0:C2} on your account!", customers[i].GetBalance());
                                        break;

                                    case 2:
                                        Console.WriteLine("How much do you want to withdraw?");
                                        bool isWithdrawParsed = int.TryParse(Console.ReadLine(), out int withdrawMoney);

                                        if (isWithdrawParsed)
                                        {
                                            if (withdrawMoney > customers[i].GetBalance())
                                            {
                                                Console.WriteLine("Insufficient balance!");
                                            }
                                            else
                                            {
                                                customers[i].SetBalance(customers[i].GetBalance() - withdrawMoney);
                                                Console.WriteLine("You withdrew {0:C2}. You have {1:C2} left on your account.", withdrawMoney, customers[i].GetBalance());
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Wrong input!");
                                        }
                                        break;

                                    case 3:
                                        Console.WriteLine("How much do you want to deposit?");
                                        bool isDepositParsed = int.TryParse(Console.ReadLine(), out int depositMoney);

                                        if (isDepositParsed)
                                        {
                                            customers[i].SetBalance(customers[i].GetBalance() + depositMoney);
                                            Console.WriteLine("You deposited {0:C2}. You have {1:C2} on your account.", depositMoney, customers[i].GetBalance());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Wrong input!");
                                        }
                                        break;

                                    case 4:
                                        Console.WriteLine("Thank you for using the ATM app");
                                        newTransaction = false;
                                        break;

                                    default:
                                        Console.WriteLine("Wrong option selected!");
                                        Console.WriteLine("Press any key to try again.");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong pin! Press any key to try again!");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input! Try again!");
                }
                break;
            }
            else if (i == customers.Length - 1 && cardNumber != customers[i].CardNumber)
            {
                Console.WriteLine("This card is not in the system!");
                Console.WriteLine("Do you want to register your card number? Y/N");

                string registerCard = Console.ReadLine();

                if (registerCard.ToLower() == "y")
                {
                    Console.WriteLine("Enter your First Name: ");
                    string newUserFirstName = Console.ReadLine();
                    Console.WriteLine("Enter your Last Name: ");
                    string newUserLastName = Console.ReadLine();
                    Console.WriteLine("Enter the balance of your account: ");
                    int newUserBalance = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your new pin: ");
                    int newUserPin = int.Parse(Console.ReadLine());

                    Customer newCustomer = new Customer(newUserFirstName, newUserLastName, newUserBalance, cardNumber, newUserPin);

                    Array.Resize(ref customers, customers.Length + 1);
                    customers[customers.Length - 1] = newCustomer;

                    Console.WriteLine("Your card has been registered successfully!");
                }
                else
                {
                    Console.WriteLine("Exiting the program...");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Something went wrong! Try again!");
            }
        }
    }
    else
    {
        Console.WriteLine("Wrong card input!");
    }
}











































//while (exitApp)
//{
//    Console.WriteLine("Welcome to the ATM app");
//    Console.WriteLine("Please enter your card number in format XXXX-XXXX-XXXX-XXXX: ");
//    string cardNumberInput = Console.ReadLine();
//    string cardNumberInputWithoutDashes = cardNumberInput.Replace("-", "");
//    bool isValidCardNumber = long.TryParse(cardNumberInputWithoutDashes, out long cardNumber);

//    if (isValidCardNumber)
//    {
//        bool cardFound = false;

//        for (int i = 0; i < customers.Length; i++)
//        {
//            if (cardNumber == customers[i].CardNumber)
//            {
//                cardFound = true;
//                Console.WriteLine("Enter pin: ");
//                bool isPinParsed = int.TryParse(Console.ReadLine(), out int pin);

//                if (isPinParsed)
//                {
//                    if (customers[i].IsPinValid(pin))
//                    {
//                        Console.WriteLine($"Welcome {customers[i].FirstName} {customers[i].LastName}!");

//                        bool newTransaction = true;
//                        while (newTransaction)
//                        {
//                            Console.WriteLine("What would you like to do: ");
//                            Console.WriteLine();
//                            Console.WriteLine("1. Check Balance");
//                            Console.WriteLine("2. Cash Withdrawal");
//                            Console.WriteLine("3. Cash Deposit");
//                            Console.WriteLine("4. Exit");
//                            bool isOptionParsed = int.TryParse(Console.ReadLine(), out int optionInput);

//                            if (!isOptionParsed)
//                            {
//                                Console.WriteLine("Wrong input!");
//                            }
//                            else
//                            {
//                                if (optionInput == 1)
//                                {
//                                    Console.WriteLine("You have {0:C2} on your account!", customers[i].GetBalance());
//                                }
//                                else if (optionInput == 2)
//                                {
//                                    Console.WriteLine("How much do you want to withdraw?");
//                                    bool isWithdrawParsed = int.TryParse(Console.ReadLine(), out int withdrawMoney);

//                                    if (isWithdrawParsed)
//                                    {
//                                        if (withdrawMoney > customers[i].GetBalance())
//                                        {
//                                            Console.WriteLine("Insufficient balance!");
//                                        }
//                                        else
//                                        {
//                                            customers[i].SetBalance(customers[i].GetBalance() - withdrawMoney);
//                                            Console.WriteLine("You withdrew {0:C2}. You have {1:C2} left on your account.", withdrawMoney, customers[i].GetBalance());
//                                        }
//                                    }
//                                    else
//                                    {
//                                        Console.WriteLine("Wrong input!");
//                                    }
//                                }
//                                else if (optionInput == 3)
//                                {
//                                    Console.WriteLine("How much do you want to deposit?");
//                                    bool isDepositParsed = int.TryParse(Console.ReadLine(), out int depositMoney);

//                                    if (isDepositParsed)
//                                    {
//                                        customers[i].SetBalance(customers[i].GetBalance() + depositMoney);
//                                        Console.WriteLine("You deposited {0:C2}. You have {1:C2} on your account.", depositMoney, customers[i].GetBalance());
//                                    }
//                                    else
//                                    {
//                                        Console.WriteLine("Wrong input!");
//                                    }
//                                }
//                                else if (optionInput == 4)
//                                {
//                                    Console.WriteLine("Thank you for using the ATM app");
//                                    newTransaction = false;
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Wrong option selected!");
//                                    Console.WriteLine("Press any key to try again.");
//                                    Console.ReadKey();
//                                }
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Wrong pin! Press any key to try again!");
//                        Console.ReadKey();
//                        Console.WriteLine();
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Wrong input! Try again!");
//                }
//                break;
//            }
//            else if (cardNumber != customers[i].CardNumber)
//            {
//                cardFound = false;
//                Console.WriteLine("This card is not in the system!");
//                Console.WriteLine("Do you want to register your card number? Y / N");

//                string cardRegister = Console.ReadLine();
//                if (cardRegister.ToLower() == "y")
//                {
//                    Console.WriteLine("Enter your First Name: ");
//                    string newUserFirstName = Console.ReadLine();
//                    Console.WriteLine("Enter your Last Name: ");
//                    string newUserLastName = Console.ReadLine();
//                    Console.WriteLine("Enter the balance of your account: ");
//                    int newUserBalance = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter your new pin: ");
//                    int newUserPin = int.Parse(Console.ReadLine());

//                    Customer newCustomer = new Customer(newUserFirstName, newUserLastName, newUserBalance, cardNumber, newUserPin);

//                    Array.Resize(ref customers, customers.Length + 1);
//                    customers[customers.Length - 1] = newCustomer;

//                    Console.WriteLine("The card number was added in the system!");
//                    break;
//                }
//                else if (cardRegister.ToLower() == "n")
//                {
//                    Console.WriteLine("Try again with correct card number!");
//                    Console.WriteLine();
//                }
//                else
//                {
//                    Console.WriteLine("Try again with correct card number!");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Wrong card input!");
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Wrong card number! Try again!");
//    }
//}

////Console.WriteLine("Thank you for using the ATM app");


