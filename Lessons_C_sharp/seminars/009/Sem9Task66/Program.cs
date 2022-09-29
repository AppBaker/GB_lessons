//=============================================
// #66  Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
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

int SumSubsequence(int start, int stop, int sum)
{
    //Точка остановки
    if (start == stop) return sum + start;
    sum += start + SumSubsequence(start + 1, stop, sum);
    return sum;
}

// Исполнение программы
int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
PrintResult($"M = {numM}; N = {numN} -> {SumSubsequence(numM, numN, 0)}");