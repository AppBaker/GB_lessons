//=============================================
// #25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Возводим число в степень
double CalculateData(int numA, int pow)
{
    return Math.Pow(numA, pow);
}


// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Выполнение программы
int number = ReadData("Введите число A: ");
int pow = ReadData("Введите степень для числа А: ");

PrintResult($"{number} в степени {pow} -> {CalculateData(number, pow)}");

