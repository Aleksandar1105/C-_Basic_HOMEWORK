
Console.WriteLine("Write something and get the last 5 characters of it:");
string inputString = Console.ReadLine();

string lastFiveCharacters = inputString.Substring(inputString.Length - 5);

Console.WriteLine("The last 5 characters are:");
Console.WriteLine(lastFiveCharacters);