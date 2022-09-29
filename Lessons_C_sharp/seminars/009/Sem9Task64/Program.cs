//=============================================
// #64  Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

string GenSubsequence(int numN)
{
    //Точка остановки
    if (numN == 0) return "";
    string outLine = numN + " " + GenSubsequence(numN - 1);
    return outLine;
}

// Исполнение программы
int numN = ReadData("Введите число N: ");
string resultLine = GenSubsequence(numN);
PrintResult($"N = {numN} -> {resultLine}");