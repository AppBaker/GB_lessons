// Чтение данных из консоли
    // int ReadData(string line)
    // {
    //     Console.Write(line);
    //     int number = int.Parse(Console.ReadLine() ?? "0");
    //     return number;
    // }

    // // Метод, принимает строку, выводит в консоль
    // void PrintResult(string line)
    // {
    //     Console.WriteLine(line);
    // }

    // int RecSumDigit(int numN)
    // {
    //     //Точка остановки
    //     if(numN==0)return 0;
    //     int sum = numN + RecSumDigit(numN -1);
    //     return sum;
    // }

    // int numN = ReadData("Введите число N: ");
    // int resultLine = RecSumDigit(numN);
    // PrintResult($"{resultLine}");

    // чтение данных из сонсоли
int ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";
    return int.Parse(inputLine);
}

// возвращает сумму цифр числа numN
int RecSumDigit(int numN)
{
    return numN == 0 ? 0 : numN % 10 + RecSumDigit(numN / 10);
}

// Вывод в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

PrintResult(RecSumDigit(ReadData("Введите число")));

int Pow(int num, int pow)
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}

Console.WriteLine($"{Pow(2, 8)}");