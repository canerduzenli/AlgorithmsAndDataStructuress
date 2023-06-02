using System;


Console.WriteLine("Please enter a number :");
int n = int.Parse(Console.ReadLine());

string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Please enter a word:");
    words[i] = Console.ReadLine();
}

Console.WriteLine("Please enter a character:");
char c = Console.ReadKey().KeyChar;

int charCount = 0;
int totalCharCount = 0;

foreach (string word in words)
{
    foreach (char wordChar in word)
    {
        if (Char.ToLower(wordChar) == Char.ToLower(c))
        {
            charCount++;
        }
        totalCharCount++;
    }
}

Console.WriteLine($"\nThe letter '{c}' appears {charCount} times in the array.");

double percentage = ((double)charCount / totalCharCount) * 100;
if (percentage > 25)
{
    Console.WriteLine("This letter makes up more than 25% of the total number of characters.");
}
else
{
    Console.WriteLine("This letter makes up less than 25% of the total number of characters.");
}
