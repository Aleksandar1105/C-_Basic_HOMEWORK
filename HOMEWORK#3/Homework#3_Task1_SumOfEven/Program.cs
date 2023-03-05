
int[] intArray = new int[6];
int sum = 0;

for (int i = 0; i < intArray.Length; i++)
{

    Console.WriteLine($"Enter integer no. {i + 1}:");
    bool isInputNumber = int.TryParse(Console.ReadLine(), out int inputNumber);
    if (!isInputNumber)
    {
        Console.WriteLine("You entered invalid input!");
        return;
    }
    else
    {
        intArray[i] = inputNumber;
    }
}

//Console.WriteLine(intArray[0]);
Console.WriteLine("Array is:");
Console.WriteLine("[{0}]", string.Join(", ", intArray));

for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] % 2 == 0)
    {
        sum += intArray[i];
    }
}
Console.WriteLine($"The sum of even numbers in array is: {sum}");