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



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


