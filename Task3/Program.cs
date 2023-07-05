// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = EnterNumberInt("Введите количество строк: ");
int n = EnterNumberInt("Введите количество столбцов: ");
int min = EnterNumberInt("Введите минимальное число: ");
int max = EnterNumberInt("Введите максимальное число: ");
int[,] array = FillArray(m, n, min, max);
PrintArray2(array);
double[] meanColumnsArray = FindMeanInColumns(array);
PrintArray1(meanColumnsArray);

int EnterNumberInt(string message)
{
    int num = 0;
    Console.Write(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

int[,] FillArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    return
    
     arr;
}

void PrintArray1 (double[] arr)
{
    Console.WriteLine();
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PrintArray2 (int[,] arr)
{
    Console.WriteLine();
    Console.WriteLine($"m = {arr.GetLength(0)}, n = {arr.GetLength(1)}");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] FindMeanInColumns(int[,] arr)
{
    double[] meanColumns = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        meanColumns[j] = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            meanColumns[j] += arr[i, j];
        }
        meanColumns[j] = Math.Round(meanColumns[j] / arr.GetLength(0), 1);
    }
    return meanColumns;
}