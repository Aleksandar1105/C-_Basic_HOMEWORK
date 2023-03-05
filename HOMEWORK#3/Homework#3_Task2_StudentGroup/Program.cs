
string[] studentsG1 = new string[5] { "Aleksandar", "Dragica", "Lina", "Natasa", "Kristijan" };
string[] studentsG2 = new string[5] { "Ivan", "Dragan", "Marko", "Dejan", "Matej" };

Console.WriteLine("Enter student group:");
bool isGroupNumberInput = int.TryParse(Console.ReadLine(), out int groupNumber);

if (!isGroupNumberInput)
{
    Console.WriteLine("You entered invalid input!");
}
else
{
    if (groupNumber == 1)
    {
        Console.WriteLine("The Students in G1 are:");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
    }
    else if (groupNumber == 2)
    {
        Console.WriteLine("The Students in G2 are:");
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }
    else
    {
        Console.WriteLine("Wrong group number! Enter 1 for students G1, or 2 for students G2!");
    }
}

