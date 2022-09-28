//=============================================
//#54  Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SplitNumbers(ref int numOne, ref int numTwo)
{
    int temp = numOne;
    numOne = numTwo;
    numTwo = temp;
}

// Сортировка массива метод пузырька
// sortUp - true по возрастанию, false по убыванию
int[,] SortRow2DArrayBubbleMethod(int[,] array, int row, bool sortUp)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        bool split = false;
        for (int i = 0; i < array.GetLength(1) - 1 - j; i++)
        {
            if (sortUp)
            {
                if (array[row, i] > array[row, i + 1])
                {
                    SplitNumbers(ref array[row, i + 1], ref array[row, i]);
                    split = true;
                }
            }
            else
            {
                if (array[row, i] < array[row, i + 1])
                {
                    SplitNumbers(ref array[row, i + 1], ref array[row, i]);
                    split = true;
                }
            }

        }
        //  Если массив отсортирован и не было перемещений то выходим из цикла
        if (!split)
        {
            break;
        }
    }
    return array;
}



int[,] Sort2DArray(int[,] array, bool sortUp = false)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SortRow2DArrayBubbleMethod(array, i, sortUp);
        }
    }
    return array;
}



// Исполнение программы
int n = ReadData("Введите количество строк: ");
int m = ReadData("Введите количество столбцов: ");
bool sortUp = ReadData("Для сортировки по возрастанию введите 1, иначе по убыванию: ") == 1 ? true : false;

int[,] matrix = Fill2DArray(n, m, 0, 10);
Print2DArray(matrix);
Console.WriteLine();
Sort2DArray(matrix, sortUp);
Print2DArray(matrix);
