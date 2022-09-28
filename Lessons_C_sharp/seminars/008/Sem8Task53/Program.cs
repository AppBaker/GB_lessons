//=============================================
// // // #53  Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю
// строку массива.
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int[,] Fill2DArray(int row, int col, int downBorder = 0, int topBorder = 10)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    int[,] arr = new int[row, col];
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

void Print2DArray(int[,] matr)
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

int[,] ReplaseRow(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;
    }
    return array;
}

// Исполнение программы
int n = ReadData("Введите количество строк");
int m = ReadData("Введите количество столбцов");
int[,] matrix = Fill2DArray(n,m, 10, 99);
Print2DArray(matrix);
ReplaseRow(matrix);
Console.WriteLine();
Print2DArray(matrix);
