

int[] intArray = new int[5];
int sum = 0;

for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine($"Enter integer no. {i + 1}:");
    bool isInteger = int.TryParse(Console.ReadLine(), out int inputNumber);
    if (!isInteger)
    {
        Console.WriteLine("Invalid input! Try with integer number!");
        return;
    }
    else
    {
        intArray[i] = inputNumber;
    }
}

Console.WriteLine("Array of integers is:");
Console.WriteLine("[{0}]", string.Join(", ", intArray));

for (int i = 0; i < intArray.Length; i++)
{
    sum += intArray[i];
}
Console.WriteLine($"The sum of integers in array is: {sum}");
