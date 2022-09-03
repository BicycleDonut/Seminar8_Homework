//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//Программа считает сумму элементов в каждой строке и выдаёт
//номер строки с наименьшей суммой элементов: 1 строка

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
void BigSum(int[,] arr)
{
    int[] res = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumString = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumString += arr[i, j];
        }
        res[i] = sumString;
    }
    int min = res[0];
    int pos = 0;
    for (int i = 1; i < res.Length; i++)
    {
        if (res[i] < min)
        {
            min = res[i];
            pos = i;
        }
    }
    Console.WriteLine($"Сумма в {pos + 1} строке меньше.");
}
int m = 3;
int n = 4;
int[,] arr = InitialArray(m, n);
BigSum(arr);