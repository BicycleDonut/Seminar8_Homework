//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] InitialArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1, 4);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return arr;
}
void MultiplicationArray(int[,] arr1, int[,] arr2)
{
    int[,] newArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        Console.WriteLine("Вычислить произведение нельзя");
        return;
    }
    else
    {
        for (int i = 0; i < newArr.GetLength(0); i++)
        {
            for (int j = 0; j < newArr.GetLength(1); j++)
            {
                int res = 0;
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    res += arr1[i, k] * arr2[k, j];
                }
                newArr[i, j] = res;
                Console.Write(newArr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

int m1 = 2, n1 = 3, m2 = 3, n2 = 2;
int[,] arr1 = InitialArray(m1, n1);
Console.WriteLine();
int[,] arr2 = InitialArray(m2, n2);
Console.WriteLine("Произведение матриц равно: ");
MultiplicationArray(arr1, arr2);

