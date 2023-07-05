// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = EnterNumberInt("Введите количество строк: ");
int n = EnterNumberInt("Введите количество столбцов: ");
double min = EnterNumberDouble("Введите минимальное число: ");
double max = EnterNumberDouble("Введите максимальное число: ");
double[,] array = FillArray(m, n, min, max);
PrintArray(array);


int EnterNumberInt(string message)
{
    int num = 0;
    Console.Write(message);
    while(!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

double EnterNumberDouble(string message)
{
    double num = 0;
    Console.Write(message);
    while(!double.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите число!");
    return num;
}

double[,] FillArray(int m, int n, double min, double max)
{
    double[,] arr = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(min + ((max - min) * random.NextDouble()), 2);
        }
    }
    return arr;
}

void PrintArray (double[,] arr)
{
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