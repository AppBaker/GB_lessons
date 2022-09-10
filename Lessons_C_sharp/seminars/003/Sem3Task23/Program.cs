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
// Вариант 1 с \t
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
// Вариант 2 со смещением
// Вычисление квадратов от 1 до number
string[] PowNumberRangeWithSpace(int number, int pow)
{
    string firstNumbers = "";
    string result = "";
    int startPoint = result.Length;
    for (int i = 1; i <= number; i++)
    {
        int firstNumberLenth = i.ToString().Length;
        firstNumbers += i.ToString();
        string num = Math.Pow(i, pow).ToString();
        int lenthOfNum = num.Length;
        result += num;
        result += " ";

        // Выравниваем
        if (i < 10)
        {
            for (int j = 0; j < lenthOfNum; j++)
            {
                firstNumbers += " ";
            }
        }
        // Когда число увеличивается в 10 раз то число смещается, уменьшаем количество добавляемых пробелов на длину числа -1
        else
            for (int j = 0; j < lenthOfNum - (firstNumberLenth - 1); j++)
            {
                firstNumbers += " ";
            }
        ;
        startPoint += result.Length;

    }
    return new string[] { firstNumbers, result };
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Исполнение программы

// Вариант 1
// Зададим степень
// int pow = 3;
// int number = ReadData("Enter number:");

// PrintResult($"{number} -> " + SquareNumberRange(number, 1));
// PrintResult($"{number} -> " + SquareNumberRange(number, pow));

// Вариант 2
// Со смещением
int number = ReadData("Enter number:");
string[] numbersArray = PowNumberRangeWithSpace(number, 3);
PrintResult($"{number} -> " + numbersArray[0]);
PrintResult($"{number} -> " + numbersArray[1]);


