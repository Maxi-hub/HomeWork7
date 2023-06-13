// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray2d()
{
    int m = Prompt("Задайте количество строк");
    int n = Prompt("Задайте количество столбцов");
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }        
    }

    return array;
}

void PrintArray2d(int[,] array2d)
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

int[,] array2d = GetArray2d();
PrintArray2d(array2d);

void GetNumber(int[,] array)
{
    int m1 = Prompt("Введите номер строки");
    int n1 = Prompt("Введите номер столбца");
    
    if(m1 <= array.GetLength(0) && n1 <= array.GetLength(1))
    { 
        int number = array[m1-1, n1-1];
        Console.WriteLine($"Значение ячейки: {number}"); 
    }
    else 
    {
        Console.WriteLine("Такого значения не существует");
    }
}

GetNumber(array2d);

