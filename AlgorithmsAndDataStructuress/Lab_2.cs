using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str1 = "Programmatic Python";
        str1 = str1.ToLower();

        List<char> duplicates = new List<char>();

        foreach (char c in str1)
        {
            int count = 0;
            foreach (char character in str1)
            {
                if (character == c)
                {
                    count++;
                }
            }

            if (count > 1 && !duplicates.Contains(c))
            {
                duplicates.Add(c);
            }
        }

        char[] result = duplicates.ToArray();
        foreach (char c in result)
        {
            Console.Write(c + " ");
        }

        Console.WriteLine();


        string str2 = "To be or not to be";
        string[] words = str2.ToLower().Split(' ');

        List<string> uniqueWords = new List<string>();

        foreach (string word in words)
        {
            if (!uniqueWords.Contains(word))
            {
                uniqueWords.Add(word);
            }
        }

        foreach (string word in uniqueWords)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine();

        string str3 = "My Name";
        char[] charArray = str3.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr3 = new string(charArray);

        Console.WriteLine(reversedStr3);


        string str4 = "Tiptoe through the tulips";
        words = str4.Split(' ');

        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine(longestWord);
    }
}
