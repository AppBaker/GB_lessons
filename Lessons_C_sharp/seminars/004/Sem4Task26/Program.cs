//=============================================
// #26
// Напишите программу, которая принимает на
//  вход число и выдаёт количество цифр в числе.
 
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int SumDigit(int number)
{
    int sumDigit = 0;
    while (number > 0)
    {
        sumDigit += (number%10);
        number = number/10;
    }
    return sumDigit;
}
// Количество цифр в числе
int DigitCount(int number)
{
    int sumDigit = 0;
    while (number > 0)
    {
        sumDigit += 1;
        number = number/10;
    }
    return sumDigit;
}


// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

PrintResult("Сумма чисел равна: " + DigitCount(ReadData("Enter number")));
