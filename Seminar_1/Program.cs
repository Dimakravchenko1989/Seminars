// Семинар 1. Знакомство с языками программирования

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(quad2 == n1)
    Console.WriteLine($"Number {n1} is square of {n2}");
else
    Console.WriteLine($"Number {n1} is not a square of {n2}");
*/


// Задача 2. Напишите программу, которая принимает на вход принимает одно число (N), а на выходе показывает все целые числа от -N до N
/*
Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

// Остаток от деления:
// 4123 % 10 -> 3
// 4123 % 100 -> 23
// 4123 % 1000 -> 123
// 4123 % 10000 -> 4123

// Целочисленное деление:
// 4123 / 10 -> 412
// 4123 / 100 -> 41
// 4123 /1000 -> 4
// 4123 / 10000 -> 0



// Задача 3. Напишите программу, которое принимает на вход трхзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}");
*/
