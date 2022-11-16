// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// Методы:

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

// void ReversArray(int[] array) // Вариант 1
// {
//      for(int i = 0; i < array.Length / 2; i++)
//      {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//      }
// }
/*
void ReverseArray(int[] array) // Вариант 2
{
     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
     {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
     }
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateRandomArray(n,min,max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/


// Задача 2. Не используя рекурсию, выведите первые N чисел Фибоначчи.Первые два числа Фибоначчи: a и b.
/*
Console.Clear();
int[] Fibonachi(int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for(int i = 2;i<size;i++)
        array[i] = array[i-1] + array[i-2];
    return array;
}
Console.Write("Input N: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibonachi(size,a,b));
*/


// Задача 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[] Copy(int[] array)
{
    int[] CopyArray = new int [array.Length];
    for(int i=0; i<array.Length;i++)
        CopyArray[i] = array[i];
    return CopyArray;
    
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n,min,max);
ShowArray(myArray);
ShowArray(Copy(myArray));
*/


// Задача 4. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
Console.Clear();
bool Triangle(int a, int b, int c)
{
    return a+b>c && a+c>b && c+b>a; // Вариант 2
    // if(a+b>c && a+c>b && c+b>a) // Вариант 1
    //     return true;
    // else
    //     return false;

}
Console.Write("Input a side length a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a side length b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a side length c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(a,b,c));
*/