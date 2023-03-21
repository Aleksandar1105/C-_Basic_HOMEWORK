

using HOMEWORK_6_Task_5.Models;

User user1 = new User(1, "Aleksandar", "12345", new[] { "Message 1", "Message 2", "Message 3" });

User user2 = new User(2, "Dragica", "00000", new[] { "Message 4", "Message 5", "Message 6" });

User user3 = new User(3, "Lina", "88888", new[] { "Message 7", "Message 8", "Message 9" });

User[] users = new[] { user1, user2, user3 };


bool repeatProgram = true;

while (repeatProgram)
{
    Console.WriteLine("Press 1 if you want to Log in:");
    Console.WriteLine("Press 2 if you want to Register:");

    bool isParsedInput = int.TryParse(Console.ReadLine(), out int optionInput);

    if (!isParsedInput)
    {
        Console.WriteLine("Invalid input! Try again!");
    }
    else
    {
        if (optionInput == 1)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool isValidCredentials = false;

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                {
                    Console.WriteLine($"Welcome {users[i].Username}. Here are your messages:");
                    for (int j = 0; j < users[i].Messages.Length; j++)
                    {
                        Console.WriteLine($"{users[i].Messages[j]}");
                    }

                    isValidCredentials = true;
                    break;
                }
            }
            if (!isValidCredentials)
            {
                Console.WriteLine("You entered invalid username or password! Try again!");
            }
        }
        else if (optionInput == 2)
        {
            Console.Write("Enter ID: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out int idNumber);
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (!isParsed)
            {
                Console.WriteLine("Invalid Id format!");
            }
            else
            {
                bool isExistingUser = false;

                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].Username == username)
                    {
                        Console.WriteLine($"There is already user {users[i].Username}. Try with other username:");
                        isExistingUser = true;
                        break;
                    }
                }
                if (!isExistingUser)
                {
                    User newUser = new User()
                    {
                        Id = idNumber,
                        Username = username,
                        Password = password
                    };
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length - 1] = newUser;

                    Console.WriteLine("Registration complete! Users: ");
                    for (int i = 0; i < users.Length; i++)
                    {
                        Console.WriteLine($"ID: {users[i].Id} | Username: {users[i].Username}");
                    }
                }
            }
        }
    }

    Console.WriteLine("Do you want to exit? Y / N");
    string inputExitProgram = Console.ReadLine();

    if (inputExitProgram.ToLower() == "y")
    {
        repeatProgram = false;
    }
    else
    {
        repeatProgram = true;
    }
}




