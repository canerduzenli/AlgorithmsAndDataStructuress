using System;
using System.Collections.Generic;


List<List<int>> lists = new List<List<int>>()
        {
            new List<int> {3, 7, 9},
            new List<int> {2, -7, 4, -2},
            new List<int> {3, 2, 6}
        };

List<int> maxNumbers = MaxNumbersInLists(lists);
for (int i = 0; i < maxNumbers.Count; i++)
{
    Console.WriteLine($"List {i + 1} has a maximum of {maxNumbers[i]}.");
}

List<List<int>> grades = new List<List<int>>()
        {
            new List<int> {45, 32, 37, 54, 94},
            new List<int> {50, 60, 57, 95},
            new List<int> {95}
        };

string highestGradeMessage = HighestGrade(grades);
Console.WriteLine(highestGradeMessage);

List<int> unorderedList = new List<int> { 6, -2, 5, 3 };
List<int> orderedList = OrderByLooping(unorderedList);
Console.WriteLine(string.Join(", ", orderedList));

// Time Complexity: O(n)
List<int> MaxNumbersInLists(List<List<int>> lists)
{
    List<int> maxNumbers = new List<int>();

    foreach (List<int> list in lists)
    {
        int max = int.MinValue;
        foreach (int num in list)
        {
            max = Math.Max(max, num);
        }
        maxNumbers.Add(max);
    }

    return maxNumbers;
}

// Time Complexity: O(n*m)

string HighestGrade(List<List<int>> grades)
{
    int maxGrade = 0;
    List<int> maxIndexes = new List<int>();

    for (int i = 0; i < grades.Count; i++)
    {
        foreach (int grade in grades[i])
        {
            if (grade > maxGrade)
            {
                maxGrade = grade;
                maxIndexes.Clear();
                maxIndexes.Add(i);
            }
            else if (grade == maxGrade)
            {
                maxIndexes.Add(i);
            }
        }
    }

    return $"The highest grade is {maxGrade}. This grade was found in class(es) {string.Join(", ", maxIndexes)}.";
}

// Time Complexity: O(n^2)
List<int> OrderByLooping(List<int> numbers)
{
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        for (int j = 0; j < numbers.Count - 1 - i; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }

    return numbers;
}