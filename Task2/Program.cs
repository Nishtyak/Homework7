// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

int m = EnterNumberInt("Введите количество строк: ");
int n = EnterNumberInt("Введите количество столбцов: ");
int min = EnterNumberInt("Введите минимальное число: ");
int max = EnterNumberInt("Введите максимальное число: ");
int[,] array = FillArray(m, n, min, max);
PrintArray(array);
Console.WriteLine();
int mIndexFind = EnterNumberInt("Введите индекс строки: ");
int nIndexFind = EnterNumberInt("Введите индекс столбца: ");
FindElement(mIndexFind, nIndexFind, array);

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

void PrintArray (int[,] arr)
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

void FindElement(int m, int n, int[,] array)
{
    if(m >= array.GetLength(0) || n >= array.GetLength(1))
        Console.WriteLine($"[{m}, {n}] -> на этой позиции числа в массиве нет");
    else Console.WriteLine($"[{m}, {n}] -> {array[m, n]}");
}
