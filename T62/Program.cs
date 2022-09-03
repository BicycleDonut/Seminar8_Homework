//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void InitialArray(int[,] arr)
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
int M = 4, N = 4;
int[,] arr = new int[M, N];
int row = 0,
    col = 0,
    stepCol = 1,
    stepRow = 0,
    turn = 0,
    dist = N;

for (int i = 0; i < arr.Length; i++)
{
    arr[row, col] = i;
    if (--dist == 0)
    {
        dist = N * (turn % 2) + M * ((turn + 1) % 2) - 2 - (turn / 2 - 1);
        int temp = stepCol;
        stepCol = -stepRow;
        stepRow = temp;
        turn++;
    }
    col += stepCol;
    row += stepRow;
}
InitialArray(arr);


