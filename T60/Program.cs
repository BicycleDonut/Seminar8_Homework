//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[] GetRandomUniqNumber(int startNumb, int endNumb) 
{
    int[] numbers = new int[endNumb - startNumb + 1];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = startNumb + i;
    }

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int index = new Random().Next(i + 1, numbers.Length);
        int temp = numbers[i];
        numbers[i] = numbers[index];
        numbers[index] = temp;
    }
    return numbers;
}

int startNum = 10,
    endNum = 99,
    count = 10;
int[] numbersUniq = GetRandomUniqNumber(startNum, endNum);
int[,,] array = new int[2, 2, 2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = numbersUniq[count];
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            count++;
        }
        Console.WriteLine();
    }
}

