//=============================================
//#60  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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
// Двузначные рекурсивно
int GetTwoDigit(List<int> twoDigitsList)
{
    int num = new Random().Next(10, 100);
    if (twoDigitsList.Contains(num))
    {
        twoDigitsList.Remove(num);
        return num;
    }
    return GetTwoDigit(twoDigitsList);
}

List<int> TwoDigitList()
{
    List<int> twoDigitsList = new List<int>();
    Random numSintezator = new Random();
    for (int i = 10; i < 100; i++)
    {
        twoDigitsList.Add(i);
    }
    return twoDigitsList;
}

(bool, int[,,]) Fill3DArray(int dimensionOne, int dimensionTwo, int dimensionThree)
{
    bool print = false;
    int[,,] arr = new int[dimensionOne, dimensionTwo, dimensionThree];
    // Проверяем длину массива
    if (dimensionOne * dimensionTwo * dimensionThree < 91)
    {
        print = true;
        List<int> digitsList = TwoDigitList();
        //Заполняем массив
        for (int i = 0; i < dimensionOne; i++)
        {
            for (int j = 0; j < dimensionTwo; j++)
            {
                for (int k = 0; k < dimensionThree; k++)
                {
                    arr[i, j, k] = GetTwoDigit(digitsList);
                }

            }
        }
    }
    else
    {
        Console.WriteLine("Слишком длинный массив");
    }

    return (print, arr);
}

void Print3DArray(int[,,] matr, bool print)
{
    if (print)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                for (int k = 0; k < matr.GetLength(2); k++)
                {
                    Console.Write(matr[i, j, k] + $"({i},{j},{k}) ");
                }
            }
            Console.WriteLine();
        }
    }
}


int n = ReadData("Введите количество строк: ");
int m = ReadData("Введите количество столбцов ");
int k = ReadData("Введите количество рядов ");
var array = Fill3DArray(n, m, k);
Print3DArray(array.Item2, array.Item1);