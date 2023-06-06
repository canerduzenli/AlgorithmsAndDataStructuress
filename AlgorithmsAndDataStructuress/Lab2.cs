

Console.WriteLine("Problem 1");

List<int> numbers = new List<int> { 1, 2, 3, 4, 7, 9, 2, 4 };
List<int> duplicates = new List<int>();

int i = 0;
int count = numbers.Count;

while (i < count)
{
    int j = i + 1;
    while (j < count)
    {
        if (numbers[i] == numbers[j] && !duplicates.Contains(numbers[i]))
        {
            duplicates.Add(numbers[i]);
            break;
        }
        j++;
    }
    i++;
}

foreach (int num in duplicates)
{
    Console.WriteLine(num);
}



Console.WriteLine("Problem 2");

int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[] { 2, 5, 7, 9, 13 };

int n = arr1.Length;
int m = arr2.Length;

int[] result = new int[n + m];

int l = 0, p = 0, k = 0;
while (l < n && p < m)
{
    if (arr1[l] <= arr2[p])
    {
        result[k++] = arr1[l++];
    }
    else
    {
        result[k++] = arr2[p++];
    }
}

while (i < n)
{
    result[k++] = arr1[l++];
}


while (p < m)
{
    result[k++] = arr2[p++];
}


for (int u = 0; u < result.Length; u++)
{
    Console.Write(result[u] + " ");

}


Console.WriteLine("Problem 3");

int nu = 3415;
int reversedNum = 0;

while (nu> 0)
{
    int digit = nu % 10;
    reversedNum = reversedNum * 10 + digit;
    nu /= 10;
}

Console.WriteLine(reversedNum);