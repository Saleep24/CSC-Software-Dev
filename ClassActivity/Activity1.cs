﻿//Problem 1
Console.WriteLine("Southern Miss to the Top!");

//Problem 2
int a = 2;
int b = 4;
int c = 6;

int result = a + 2 * b + 3/8;

//Problem 3
int d = 3;
int e = 5;

Console.WriteLine("The larger number is: " + Math.Max(d, e));

//Problem 4
int sum = 0;

for (int i = 2; i <= 20; i +=4)
{
    sum += i;
}
Console.WriteLine("The sum is: " + sum);

//Problem 5
int [] numbers = {5, 15, 90, 23, 18, 5, 4};
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= 3;
}

//To print the array
// foreach (int num in numbers)
// {
//     Console.Write(num+ " ");
// }
