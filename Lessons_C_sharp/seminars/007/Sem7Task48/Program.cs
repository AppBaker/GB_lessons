
//=============================================
// // #48  Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4. 01 2 3
// 12 3 4
// 23 4 5
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

// Заполняем массив 
void Fill2DArray(int[,] matr)
{
// Сводка:
//     Writes the specified array of Unicode characters, followed by the current line
//     terminator, to the standard output stream.
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
}


int m = ReadData("Введите количество столбцов");
int n = ReadData("Введите количество строк");
int[,] matrix = new int[m, n];

Fill2DArray(matrix);
Print2DArray(matrix);

var isEven = (int v) => v % 2 == 0;
Console.WriteLine(isEven(4));
