// Семинар 7.
/*
Задача 1. Задать двумерный массив определенными размерами и запольнить его случайными числами.
*/


int [,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int [rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of coluns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m,n,min,max);
// Show2dArray(myArray);


// --------------------------------------------------------------
// Задача 2. Задайте двумерный массив m, n каждый элемент в массиве находится по формуле Aij = i+j и вывести массив на экран.


// int [,] CreateArray(int rows, int colums)
// {
//     int[,] array = new int [rows, colums];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < colums; j++)
//             array[i,j] = i + j;
        
//     return array;
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of coluns: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = CreateArray(m,n);
// Show2dArray(myArray);



// -------------------------------------------------------------
// Задача 3. Задайте двумерный массив, найти элементы, у которых оба индекса четные и заменить эти элементы на их квадраты.
// 
// 
// int [,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int [rows, colums];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < colums; j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
        
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SearchAndReplaceArray(int[,] array)
// {
    
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j+=2)
//             array[i,j] *= array[i,j];
        
// }


// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of coluns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m,n,min,max);
// Show2dArray(myArray);
// SearchAndReplaceArray(myArray);
// Show2dArray(myArray);



// Задача 4. Задайте двумерный массив и найти сумму элементов находящихся на главной диагонали (i=j).


// int SumDiagonale(int[,] array)
// {
//     int sum = 0;
//     for(int i = 0; i< array.GetLength(0) && i<array.GetLength(1); i++)
//         sum +=array[i,i];
//     return sum;


// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of coluns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = CreateRandom2dArray(m,n,min,max);
// Show2dArray(myArray);
// Console.Write($"Sum diagonale: {SumDiagonale(myArray)}");

