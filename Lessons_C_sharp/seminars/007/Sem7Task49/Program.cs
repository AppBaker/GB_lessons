//=============================================
// // #49  Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Заполнение массива
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

int[,] Update2DArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < array2d.GetLength(1); j = j + 2)
        {
            array2d[i, j] = array2d[i, j] * array2d[i, j];
        }
    }

    return array2d;
}

int m = ReadData("Введите количество столбцов");
int n = ReadData("Введите количество строк");
int[,] matrix = Fill2DArray(n, m, 10, 99);
Print2DArray(matrix);
Update2DArray(matrix);
Console.WriteLine();
Print2DArray(matrix);