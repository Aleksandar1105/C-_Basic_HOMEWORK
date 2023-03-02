

Console.WriteLine("Enter the First number:");
bool userInputNumber1 = int.TryParse(Console.ReadLine(), out int number1);
//Console.WriteLine(userInputNumber1);

Console.WriteLine("Enter the Second number:");
bool userInputNumber2 = int.TryParse(Console.ReadLine(), out int number2);

Console.WriteLine("Enter the Third number:");
bool userInputNumber3 = int.TryParse(Console.ReadLine(), out int number3);

Console.WriteLine("Enter the Fourth number:");
bool userInputNumber4 = int.TryParse(Console.ReadLine(), out int number4);

int averageNumber = (number1 + number2 + number3 + number4) / 4;

Console.WriteLine("The average of " + number1 + ", " + number2 + ", " + number3 + " and " + number4 + " is: " + averageNumber);



Console.ReadLine(); 