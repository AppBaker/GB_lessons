//=============================================
// // #51  Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.
// Например:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
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

int SumOfElements(int[,] matrix)
{
    int sum = 0;
    int len = matrix.GetLength(0) > matrix.GetLength(1) ? matrix.GetLength(1) : matrix.GetLength(0);
    for (int i = 0; i < len; i++)
    {
        sum += matrix[i,i];
    }
    return sum;
}


int m = ReadData("Введите количество столбцов");
int n = ReadData("Введите количество строк");
int[,] matrix = Fill2DArray(n, m, 10, 99);
Print2DArray(matrix);
Console.WriteLine($"Сумма элементов по диагонали: {SumOfElements(matrix)}" );