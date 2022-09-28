//=============================================
// #57  Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.
//=============================================

// Создает двумерный массив размером m×n
// int[,] GenerateArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     Random rand = new Random();
//     int[,] array = new int[countRow, countColumn];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rand.Next(topBorder, downBorder);
//         }
//     }
//     return array;
// }

// // Возвращает частотный словарь элементов двумерного массива
// SortedDictionary<int, int> CountDictionary(int[,] array)
// {
//     SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if (dict.ContainsKey(array[j, i]))
//                 dict[array[j, i]] = dict[array[j, i]] + 1;
//             else
//                 dict.Add(array[j, i], 1);
//         }
//     }
//     return dict;
// }

// // вывод двумерного массива
// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");

//         }
//         Console.WriteLine();
//     }
// }

// // вывод ответа
// void PrintAnswer(string answer, string title = "")
// {
//     Console.WriteLine("{0} -> {1}", title, answer);
// }



// int[,] array = GenerateArray(5, 5, 0, 10);

// Console.WriteLine("\n------- Исходная матрица -------\n");
// Print2DArray(array);

// SortedDictionary<int, int> dict = CountDictionary(array);

// PrintAnswer("Сколько повторений\n", "\nЧисло");
// foreach (KeyValuePair<int, int> kvp in dict)
// {
//     PrintAnswer(kvp.Value.ToString(), kvp.Key.ToString());
// }

// Генерация случайного 2D массива.
int[,] Gen2DArr(int rows, int columns, int arrMin, int arrMax)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }
    int range = arrMax - arrMin;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

Dictionary<int, int> FreqDict(Dictionary<int, int> countValues, int[,] arr)
{
    foreach (int item in arr)
    {
        if (countValues.ContainsKey(item))
        {
            countValues[item]++;
        }
        else
        {
            countValues.Add(item, 1);
        }
    }
    return countValues;
}

// Печать словаря.
void PrintDict(Dictionary<int, int> countValues)
{
    foreach (var item in countValues)
    {
        Console.WriteLine(item);
    }
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
    Console.WriteLine();
}


int[,] arr = Gen2DArr(10, 10, 0, 10);
Dictionary<int, int> countValues = new Dictionary<int, int>();
Print2DArray(arr);
FreqDict(countValues, arr);
PrintDict(countValues);