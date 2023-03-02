
int branches = 12;

Console.WriteLine("Enter the number of trees:");
bool inputTreesNumber = int.TryParse(Console.ReadLine(), out int treesNumber);

Console.WriteLine("Enter the number of apples on each branch:");
bool inputapplesNumber = int.TryParse(Console.ReadLine(), out int applesNumber);

Console.WriteLine("Enter the number of apples in one busket:");
bool inputApplesInOneBasketNumber = int.TryParse(Console.ReadLine(), out int applesInOneBasket);


if (!inputTreesNumber || !inputapplesNumber || !inputApplesInOneBasketNumber)
{
    Console.WriteLine("You entered invalid input. Enter the number of trees!");
}
else
{
    int totalApples = treesNumber * branches * applesNumber;
    int basketsNeeded = totalApples / applesInOneBasket;
    Console.WriteLine($"You need {basketsNeeded} baskets to collect all the apples!");
}


Console.ReadLine();