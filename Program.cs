// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/* 
double [,] Create2dRealArray ()
{
    Console.Write ("Input number of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of column: ");
    int columns = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input min possible value: ");
    int minValue = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input max possible value: ");
    int maxValue = Convert.ToInt32 (Console.ReadLine());

    double [,] createdArray = new double [rows, columns];

    for (int i = 0; i < rows; i++)
        for ( int j = 0; j < columns; j++)
            createdArray [i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);

    return createdArray;
}

void Show2dArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + "  ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

double [,] newRealArray = Create2dRealArray ();
Show2dArray (newRealArray);
 */

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

/* 
int [,] Create2dArray ()
{
    Console.Write ("Input number of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of column: ");
    int columns = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input min possible value: ");
    int minValue = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input max possible value: ");
    int maxValue = Convert.ToInt32 (Console.ReadLine());

    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for ( int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minValue, maxValue + 1);

    return createdArray;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}


bool CheckIndex (int index1, int index2, int [,] array)
{
    if (index1 >= array.GetLength(0) || index1 < 0 || index2 >= array.GetLength(1) || index2 < 0) return false;
    else return true;
}

int [,] newArray = Create2dArray ();
Console.WriteLine ();
Console.WriteLine("Two-dimensional array:");
Show2dArray (newArray);

Console.Write("Input number array row: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number array column: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ();

bool result = CheckIndex (num1, num2, newArray);
if (result)
{
    Console.WriteLine($"Value of array element [{num1}, {num2}] = {newArray [num1, num2]}.");
}
else
{
    Console.WriteLine($"Value of array element [{num1}, {num2}] does not exist.");
}
 */

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/* 
int [,] Create2dArray ()
{
    Console.Write ("Input number of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of column: ");
    int columns = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input min possible value: ");
    int minValue = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input max possible value: ");
    int maxValue = Convert.ToInt32 (Console.ReadLine());

    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for ( int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minValue, maxValue + 1);

    return createdArray;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

double [] ArithmeticMeanArray (int [,] arr)
{
    double [] arMeanArray = new double [arr.GetLength(1)];
    double sum = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
        sum += arr [i,j];
        }
        arMeanArray [j] = Math.Round (sum / arr.GetLength(0), 2);
        sum = 0;
    }
        return arMeanArray;
}

void ShowArray (double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}; ");
    }
    Console.WriteLine("\b\b]");
}

int [,] newArray = Create2dArray ();
Console.WriteLine ();
Console.WriteLine("Two-dimensional array:");
Show2dArray (newArray);

double [] array = ArithmeticMeanArray (newArray);
Console.WriteLine("Arithmetic mean of each array column:");
ShowArray (array);
 */
