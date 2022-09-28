//=============================================
//#58  Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] multMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {

        for (int i = 0; i < multMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multMatrix.GetLength(1); j++)
            {
                for (int c = 0; c < multMatrix.GetLength(1); c++)
                {
                    multMatrix[i, j] += matrixA[i, c] * matrixB[c, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Нельзя перемножить матрицы");
    }

    return multMatrix;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Массив А
int n = ReadData("Введите количество строк массива А: ");
int m = ReadData("Введите количество столбцов массива А: ");
// Массив Б
int o = ReadData("Введите количество строк массива Б: ");
int p = ReadData("Введите количество столбцов массива Б: ");

int[,] matrixA = Fill2DArray(n, m, 1, 5);
int[,] matrixB = Fill2DArray(o, p, 1, 5);
Console.WriteLine();
PrintResult("Матрица А");
Print2DArray(matrixA);
Console.WriteLine();
PrintResult("Матрица Б");
Print2DArray(matrixB);
Console.WriteLine();
PrintResult("Матрица А * Б");
Print2DArray(MatrixMultiplication(matrixA, matrixB));

