// Задача 1. Напишите программу, которая принимает на вход число N и выдает сумму чисел от 1 до числа N.
/*
int FindSum(int number)
{
    int sum = 0;

    for(int current = 1;current <= number; current++)
        sum +=current;


    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}"); 
*/



// Задача 2. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
/*
int NumberOfDigit(int number)
{
    int count = 0;
    while(number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number of digit {NumberOfDigit(a)}");
*/



// Задача 3. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
/*
long Factorial (int n)
{
    long sum = 1;
    for(int current = 1; current <= n; current++)
    {
        sum *= current;
    }
    return sum;
}
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Factorial = {Factorial(a)}");
*/



// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненый 0 и 1 в случайном порядке.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Array is: ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" \n");
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateRandomArray(n,min,max);
ShowArray(myArray);
*/