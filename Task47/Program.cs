// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetArray2d()
{
    int m = Prompt("Введите значение m");
    int n = Prompt("Введите значение n");
    double[,] array = new double[m, n];
    Random random = new Random();  // создание объекта генератора случайных чисел
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round((random.NextDouble() * 20 - 10), 2);
        }        
    }
    return array;
}

void PrintArray2d(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double[,] array2d = GetArray2d();
PrintArray2d(array2d);
