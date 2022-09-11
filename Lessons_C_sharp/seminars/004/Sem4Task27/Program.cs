//=============================================
// #27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

 
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Расчитываем сумму цифр в числе
// Метод 1
double CalculateSumDigit(int number)
{
    int sumDigit = 0;
    while (number > 0)
    {
        sumDigit += (number%10);
        number = number/10;
    }
    return sumDigit;
}

// Метод 2 - через разбите числа на символы
double CalculateSumDigit_(int number)
{
    int sumDigit = 0;
    char[] charArray = number.ToString().ToCharArray();
    for (int i = 0; i < charArray.Length; i++)
    {
        sumDigit += (int)Char.GetNumericValue(charArray[i]);
    }
    return sumDigit;
}


// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Выполнение программы
int number = ReadData("Введите число: ");

PrintResult($"Сумма чисел в числе {number} равна -> {CalculateSumDigit(number)}");
PrintResult($"Сумма чисел в числе {number} равна -> {CalculateSumDigit_(number)}");

