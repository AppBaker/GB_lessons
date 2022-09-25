//=============================================
// // #47  Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
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

// Разноцветная печать
void PrintColor(double str, ConsoleColor[] color, bool byChar = false)
{
    if (byChar)
    {
        foreach (var item in str.ToString().ToCharArray())
        {
            Console.ForegroundColor = color[new System.Random().Next(0, color.Length)];
            Console.Write(item);
            Console.ResetColor();
        }
        Console.Write(" ");
    }
    else
    {
        Console.ForegroundColor = color[new System.Random().Next(0, color.Length)];
        Console.Write(str + " ");
        Console.ResetColor();
    }

}


// Печать двумерного массива
void Print2DArray(double[,] matr, bool eachChar = false)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            PrintColor(matr[i, j], col, eachChar);
        }
        Console.WriteLine();
    }
}

// Заполнение двумерного массива
double[,] Fill2DArray(int row, int col, int downBorder = 0, int topBorder = 10)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    double[,] arr = new double[row, col];
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
            arr[i, j] = Math.Round(numSintezator.NextDouble() * (double)numSintezator.Next(downBorder, topBorder + 1), 1);
        }
    }
    return arr;
}


// Исполнение программы
int n = ReadData("Введите количество строк");
int m = ReadData("Введите количество столбцов");
bool colored = ReadData("Расскрасить каждый символ массива: да(1) нет(2)") == 1 ? true : false;
double[,] matrix = Fill2DArray(n, m, -99, 99);
Print2DArray(matrix, eachChar: colored);
