//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] InitialArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] ArrayMax(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            int maxElement = arr[i, j];
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > maxElement)
                {
                    arr[i, j] = arr[i, k];
                    arr[i, k] = maxElement;
                    maxElement = arr[i, j];
                }
            }
        }
    }
    return arr;
}
int M = 3;
int N = 4;
int[,] InitialNumbers = InitialArray(M, N);
Console.WriteLine();
ArrayMax(InitialNumbers);
PrintArray(InitialNumbers);

