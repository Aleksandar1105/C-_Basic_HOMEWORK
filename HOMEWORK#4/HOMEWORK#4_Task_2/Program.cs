
Console.WriteLine("Write sentence to print its words:");
string sentence = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Words of sentence are:");
string[] wordsOfSentence = sentence.Split(" ");
for (int i = 0; i < wordsOfSentence.Length; i++)
{
    Console.WriteLine(wordsOfSentence[i]);
}
