// Семинар 3.Знакомство с языками программирования


// Задача 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowQuart(int quartNum)
{
    if (quartNum >= 1 && quartNum <= 4)
    {
        if(quartNum == 1) Console.WriteLine("x > 0 and y > 0");
        else if(quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if(quartNum == 3) Console.WriteLine("x < 0 and y < 0");
        else Console.WriteLine("x > 0 and y < 0");
    }
    else
        Console.WriteLine ("Wrong number!");
}

Console.Write("Imput a mamber of quart: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowQuart(num);
*/


// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int quarter(double x,double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y > 0) return 4;
    return 0;
}
Console.WriteLine("Введите координату х: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int result1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Номер четверти: {quarter(result, result1)}");
*/

   

// Задача 3. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
/*
double Distance(double x1, double y1, double x2, double y2)
{
    double katet1 = x1 - x2;
    double katet2 = y1 - y2;
    double gipotenuza = Math.Sqrt(katet1*katet1 + katet2*katet2);
    return gipotenuza;
}
Console.WriteLine("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние равно: {Distance(x1,y1,x2,y2)}");
*/



// Задача 4. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
/*
void Table(int number)
{
    int index = 1;
    while (index <= number)
    {
        double result = Math.Pow(index,2);
        Console.Write(result + " ");
        index++;
    }
}
Console.Write("Введите число: ");
int res = Convert.ToInt32(Console.ReadLine());
Table(res);
*/

