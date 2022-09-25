//=============================================
// // #52  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
//=============================================

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

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
// Цветная печать 1D массива
void Print1DArrWithColor((double, ConsoleColor)[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = arr[i].Item2;
        Console.Write(Math.Round(arr[i].Item1, 2) + " ");
        Console.ResetColor();

    }
    Console.WriteLine();
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
// Считаем стреднее арифметическое в столбце
double AverageCalc(int[,] array, int col)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += (double)array[i, col - 1];
    }
    return sum / array.GetLength(0);
}

// Среднее арифметическое а столбцах
string AverageCalcInСolumns(int[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(1); i++)
    {
        result += $"{Math.Round(AverageCalc(array, i + 1), 1)} ";
    }
    return result;
}



// Массив цветов для диагоналей
ConsoleColor[] GetColors(int count)
{
    Random numSintezator = new Random();
    ConsoleColor[] colors = new ConsoleColor[count];
    for (int i = 0; i < count; i++)
    {
        colors[i] = col[numSintezator.Next(0, col.Length)];
    }
    return colors;
}

//  Поиск диагонаей
(double, ConsoleColor)[] DiagonalOf2DArray(int[,] array)
{
    // Массив Вывода стредних арифметических с цветами
    (double, ConsoleColor)[] averageCountsInDiagonals = new (double, ConsoleColor)[array.GetLength(0) + array.GetLength(1) - 1];
    // Массив счетчиков длины диагоналей
    int[] diagonalLenthCounts = new int[array.GetLength(0) + array.GetLength(1) - 1];
    // Массив случайных цветов диагоналей
    ConsoleColor[] colors = GetColors(averageCountsInDiagonals.Length);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int d = -(array.GetLength(0) - 1); d < array.GetLength(1); d++)
            {
                if (i + d == j)
                {
                    int diagonal = d + (array.GetLength(0) - 1);
                    averageCountsInDiagonals[diagonal].Item1 += array[i, j];
                    averageCountsInDiagonals[diagonal].Item2 = colors[diagonal];
                    diagonalLenthCounts[diagonal]++;
                    Console.ForegroundColor = colors[diagonal];
                    Console.Write(array[i, j] + " ");
                    Console.ResetColor();
                }
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    // Считаем среднее арифметическое в диагоналях
    for (int i = 0; i < diagonalLenthCounts.Length; i++)
    {
        averageCountsInDiagonals[i].Item1 = (double)averageCountsInDiagonals[i].Item1 / (double)diagonalLenthCounts[i];
    }
    return averageCountsInDiagonals;
}


void PrintResult(string line)
{
    Console.WriteLine(line);
}



// Исполнение программы
// int n = ReadData("Введите количество строк");
// int m = ReadData("Введите количество столбцов");
// int[,] matrix = Fill2DArray(n, m, 10, 99);
// Print2DArray(matrix);
// PrintResult($"СРеднее арифметическое в столбцах: {AverageCalcInСolumns(matrix)}");

// Исполнение программы *
int n = ReadData("Введите количество строк");
int m = ReadData("Введите количество столбцов");
int[,] matrix = Fill2DArray(n, m, 10, 99);

Print1DArrWithColor(DiagonalOf2DArray(matrix));
