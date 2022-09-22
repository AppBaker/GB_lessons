//=============================================
// // #46  Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Например: 
// m = 3, n = 4. 
// -1 4 8 19
// 5 -2 3 3
//  -2 -77 3 81
//=============================================

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
    //Создаем массив
    int[,] arr = new int[row,col];
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
            arr[i,j] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    //Возвращаем результат
    return arr;
}


