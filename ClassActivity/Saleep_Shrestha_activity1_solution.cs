/*
Name: Saleep Shrestha
Student ID: w10167735
Assignment: C# Practice Problems, Part 1
 */

using System;

class ClassActivity
{
    static int IsGreaterThan(int[] arr, int num)
    {
        int count = 0;
        foreach (int n in arr)
            if (n > num) count++;
        return count;
    }
    static void Main(string[] args)
    {
        //Problem 1
        Console.WriteLine("Southern Miss to the Top!");

        //Problem 2
        int a = 2;
        int b = 4;
        int c = 6;

        int result = a + 2 * b + 3 / 8;

        //Problem 3
        int d = 3;
        int e = 5;

        Console.WriteLine("\nThe largest number is: " + Math.Max(d, e));

        //Problem 4
        int sum = 0;

        for (int i = 2; i <= 20; i += 4)
        {
            sum += i;
        }

        Console.WriteLine("\nThe sum is: " + sum);

        //Problem 5
        int[] numbers = { 5, 15, 90, 23, 18, 5, 4 };
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 3;
        }
        Console.WriteLine("\nModified array: " + string.Join(" ", numbers));
        
        //Problem 6
        int[] testArray = { 4, 5, 19, 20, 5, 1, 12, 15, 100 };
        int testValue = 15;
        Console.WriteLine($"\nCount greater than {testValue}: " + IsGreaterThan(testArray, testValue));
    }
}
