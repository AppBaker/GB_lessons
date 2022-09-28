//=============================================
//#56  Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "0";
    inputLine = inputLine == "" ? "0" : inputLine;
    int result = int.Parse(inputLine);
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

(int, int) MaxElementInArray(int[] array)
{
    int max = array[0];
    int number = 1;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > max)
        {
            max = array[i];
            number = i + 1;
        }
    }
    return (number, max);
}

int[] SumOfRowsIn2dArray(int[,] matr)
{
    int[] sumRowsIn2DArray = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRowsIn2DArray[i] += matr[i, j];
        }
    }
    return sumRowsIn2DArray;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}




// Исполнение программы
int n = ReadData("Введите количество строк: ");
int m = ReadData("Введите количество столбцов: ");
int[,] matrix = Fill2DArray(n, m, 0, 10);
Print2DArray(matrix);
(int,int) max = MaxElementInArray(SumOfRowsIn2dArray(matrix));
PrintResult($"Максимальная сумма в строке {max.Item1} = {max.Item2}");