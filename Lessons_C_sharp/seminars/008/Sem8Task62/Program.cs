//=============================================
//#62 Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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

// Заполняем один круг
int[,] FillRound(int[,] array, ref int fromInt, int round)
{
    for (int i = round - 1; i < array.GetLength(1) - round; i++)
    {
        array[round - 1, i] = fromInt;
        fromInt += 1;
    }
    for (int j = round - 1; j < array.GetLength(0) - round; j++)
    {
        array[j, array.GetLength(1) - round] = fromInt;
        fromInt += 1;
    }
    for (int k = array.GetLength(1) - round; k > round - 1; k--)
    {
        array[array.GetLength(0) - round, k] = fromInt;
        fromInt += 1;
    }
    for (int c = array.GetLength(0) - round; c > round - 1; c--)
    {
        array[c, round - 1] = fromInt;
        fromInt += 1;
    }
    return array;
}

// Заполнение по спирали
int[,] Fill2DArraySpyral(int row, int col)
{
    int starrNumber = 0;
    int[,] spiralArray = new int[row, col];

    int rounds = row / 2;

    for (int i = 1; i <= rounds; i++)
    {
        FillRound(spiralArray, ref starrNumber, i);
    }
    if (row % 2 > 0)
    {
        spiralArray[row / 2, col / 2] = starrNumber;
    }
    return spiralArray;
}

void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write("0" + matr[i, j] + " ");
            }
            else Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// Исполнение программы
int n = ReadData("Введите размер массива: ");
Print2DArray(Fill2DArraySpyral(n, n));