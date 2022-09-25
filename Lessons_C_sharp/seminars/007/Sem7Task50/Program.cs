//=============================================
// // #50  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
//=============================================

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Заполнение  двумерного массива
long[,] Fill2DArray(int row, int col, int downBorder = 0, int topBorder = 10)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    long[,] arr = new long[row, col];
    //Тест границ
    if (downBorder > topBorder)
    {
        int temp = downBorder;
        downBorder = topBorder;
        topBorder = temp;
    }
    //Заполняем массив
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    return arr;
}

// Печать двумерного массива
void Print2DArray(long[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// Печатаем массив и выделяем элемент цветом
void SelectElementIn2DArray(long[,] matr, int row, int col)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == row - 1 && j == col - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matr[i, j] + " ");
                Console.ResetColor();
            }
            else Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


(bool, long) FindElementIn2DArray(long[,] array, int row, int col)
{
    if (row > array.GetLength(0) || col > array.GetLength(1) || row < 1 || col < 1)
    {
        return (false, -1);
    }
    else
    {
        SelectElementIn2DArray(array, row, col);
        return (true, array[row - 1, col - 1]);
    }
}


void PrintResult((bool, long) result)
{
    if (result.Item1)
    {
        Console.WriteLine($"Значение элемента: {result.Item2}");
    }
    else
    {
        Console.WriteLine($"Такого элемента нет");
    }
}


long[,] Fill2DArrayFibonachiNumbers(int row, int col)
{
    long[,] arr = new long[row, col];
    long first = 0;
    long last = 1;
    long buf = 0;
    //Заполняем массив числами Фибоначи
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = first;
            buf = first + last;
            first = last;
            last = buf;
        }
    }
    return arr;
}

// Исполнение программы
// long[,] matrix = Fill2DArray(10, 10, -99, 99);
// Print2DArray(matrix);
// int n = ReadData("Введите номер строки");
// int m = ReadData("Введите номер столбца");
// PrintResult(FindElementIn2DArray(matrix, n, m));

// // Исполнение программы *
long[,] matrix = Fill2DArrayFibonachiNumbers(5, 5);
Print2DArray(matrix);
int n = ReadData("Введите номер строки");
int m = ReadData("Введите номер столбца");
PrintResult(FindElementIn2DArray(matrix, n, m));
