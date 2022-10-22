// Семинар 2 Знакомство с языками программирования


// Задача 1. Напишите программу, которая выводит случайное число из отрезка [100,1000] и показывает первую и третью цифру. 
/*
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100,1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/


// Задача 2. Напишите программу , которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
/*
int MaxNumber(int number)
{
    int des = number / 10;
    int ed = number % 10;
    if(des > ed)
        return des;
    else
        return ed;
}

int randNum = new Random().Next(10,100);
int result = MaxNumber(randNum);
Console.WriteLine($"Случайное число {randNum} максимальное в нем {result}");
*/


// Задача 3. Напишите программу, которая приимает на вход два числа и проверает, является ли одно число квадратом другого.
/*
bool Sqrt(int num1,int num2)
{
    if(num1 * num2 == num2||num2 * num2 == num1)
        return true;
    else
        return false;
} 
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sqrt(num1,num2));
*/


// Задача 4. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool Kratnoe(int num1,int num2)
{
    if(num1 % num2 == 0)
        return true;
    else
        return false;
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Kratnoe(num1, num2));
*/


// Задача 5. Напишите программу, которая на вход принимает 3 целых числа a, m, n и проверяет кратно ли число a одновременно числам m и n, числа задаются пользователем.
/*
bool Kratnoe(int a1,int m1,int n1)
{
    if(a1 % n1 == 0 && a1 % m1 == 0)
        return true;
    else
        return false;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Kratnoe(a,m,n));
*/
