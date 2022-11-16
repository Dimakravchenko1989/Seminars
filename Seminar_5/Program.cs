// Семинар 5.
// Задача 1. Задать массив из 12 элементов, заполненый случайными числами из промежутка от -9 до 9.
// Найти сумму отрицательных элементов массива.
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
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " " );
    Console.Write(" \n");
}

int GetNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    return sum;    
}


Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n,min,max);
ShowArray(myArray);

int negativeSum = GetNegativeSum(myArray);
Console.WriteLine("Sum of negative elements is " + negativeSum);
*/


// Задача 2. Задайте массив и напишите программу, которая определит присутствует ли заданное число в массиве.

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
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " " );
    Console.WriteLine();
}
bool FindNum(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
            return true;
    }
    return false;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(5,1,2);
ShowArray(array);
Console.WriteLine(FindNum(array,num));
*/

// Задача 3. Необходимо задать одномерный массив из m случайных чисел.
// Найти количество элементов массива, значения которых лежат в отрезке от А до Б. (А и Б тоже будут вводить).
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
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " " );
    Console.WriteLine();
}
int Count(int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i]<= max)
            count++;
    }
    return count;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size,99,999);
ShowArray(array);
Console.WriteLine(Count(array,min,max));
*/


// Задача 4. Напишите программу замены элементов массива (положительные на отрицательные).



// ДЗ 5.

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " " );
    Console.WriteLine();
}

int EvenNumbers(int[]array)
{
int quantity= 0;
    for (int i=0; i< array.Length; i++ )
    {
       if (array[i]%2==0)
        quantity++; 
    }
    return quantity;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,100,1000);
ShowArray(array);
Console.WriteLine(EvenNumbers(array));
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

/*
Console.Clear();
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " " );
    Console.WriteLine();
}

int SumOddElements(int[]array)
{
    int sum = 0;

    for (int i=0; i< array.Length; i++ )
    {
       if(i%2!=0)
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size,-10,100);
ShowArray(array);
Console.WriteLine($"Сумма элементов массива стоящих на нечётных позициях равна: {SumOddElements(array)}");
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
Console.Clear();

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        array[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" \n");
}

double GetDiffMinMax(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    diff = max - min;

    return diff;
}

Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] RandomArrayReal = CreateRandomArray(size, -10, 11);
ShowArray(RandomArrayReal);

Console.Write($"Разница между максимальным и минимальным элементами массива равна: {GetDiffMinMax(RandomArrayReal)}");
*/