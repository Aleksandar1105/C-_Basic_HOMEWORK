

string[] namesArray = new string[10];
int index = 0;
string input;

do
{
    Console.Write("Enter a name: ");
    namesArray[index++] = Console.ReadLine();

    Console.Write("Do you want to enter another name? ( Y / N ): ");
    input = Console.ReadLine().ToUpper();
}
while (input == "Y");

Console.WriteLine("All names:");
for (int i = 0; i < index; i++)
{
    Console.WriteLine(namesArray[i]);
}