//=============================================
// #22 Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4
//=============================================

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;

}

// Вычисление квадратов от 1 до number
string SquareNumberRange(int number, int pow)
{
    string result = "\t";
    for (int i = 1; i <= number; i++)
    {
        result += Math.Pow(i, pow).ToString();
        result += "\t";
    }
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Исполнение программы
int number = ReadData("Enter number:");

PrintResult($"{number} -> " + SquareNumberRange(number, 1));
PrintResult($"{number} -> " + SquareNumberRange(number, 2));








