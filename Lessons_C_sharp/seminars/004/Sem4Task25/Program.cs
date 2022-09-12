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
// int number = ReadData("Введите число A: ");
// int pow = ReadData("Введите степень для числа А: ");

// PrintResult($"{number} в степени {pow} -> {CalculateData(number, pow)}");

// ########################
// Калькулятор *
// ########################

// Сумма чисел
double SumOfNumbers(double num1, double num2)
{
    return num1 + num2;
}

// Разница чисел
double SubtractionOfNumbers(double num1, double num2)
{
    return num1 - num2;
}

// Деление чисел
double DivisionOfNumbers(double num1, double num2)
{
    return num1 / num2;
}

// Умножение чисел
double MultiplicationOfNumbers(double num1, double num2)
{
    return num1 * num2;
}

//  Возведение в степень
double PowOfNumbers(double num1, double num2)
{
    return Math.Pow(num1, num2);
}

// Метод вычисления
double Calculate(double num1, double num2, Func<double, double, double> CalcFunc)
{
    return CalcFunc(num1,num2);
}

// Получение результата
double? GetCalculationResult(double num1, double num2, string action)
{
    if (action == "+") return Calculate(num1, num2, SumOfNumbers);
    if (action == "-") return Calculate(num1, num2, SubtractionOfNumbers);
    if (action == "*") return Calculate(num1, num2, MultiplicationOfNumbers);
    if (action == "/") return Calculate(num1, num2, DivisionOfNumbers);
    if (action == "**") return Calculate(num1, num2, PowOfNumbers);
    return null;
}

// Выполнение программы Калькулятор
Console.WriteLine("Это калькулятор, он производит простые вычисления ( + ; - ; * ; / ; ** )");
int numA = ReadData("Введите число A: ");
Console.WriteLine("Введите действие ( + ; - ; * ; / ; ** ) :");
string? action =  Console.ReadLine() ?? "";
int numB = ReadData("Введите число Б: ");

double? result = GetCalculationResult(numA, numB, action);

 if (result != null)
{
    PrintResult($"{numA} {action} {numB} = {result}");
}
else 
{
    PrintResult("Вы ввели неверное выражение");
}



