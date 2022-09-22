//=============================================
// // #41  Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

//  Подсчет положительных чисел введеных пользователем
(int, int[]) PositiveNumbersCount(int iterations)
{
    int[] enteredNumbers = new int[iterations];
    int count = 0;
    for (int i = 0; i < iterations; i++)
    {
        int enteredNumber = ReadData($"Введите число, осталось ввести({iterations - i} шт)");
        enteredNumbers[i] = enteredNumber;
        if (enteredNumber > 0) count++;
    }
    return (count, enteredNumbers);
}

//Преобразование массива в строку
string ArrayStrToString(string[] arr)
{
    return string.Join("; ", arr);
}

//Преобразование массива в строку
string ArrayIntToString(int[] arr)
{
    return string.Join("; ", arr);
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// 
(int, string[]) PositiveNumbersReadKey(int iterations)
{
    string[] enteredSymbols = new string[iterations];
    int count = 0;
    for (int i = 0; i < iterations; i++)
    {
        var enteredNumber = Console.ReadKey();
        // Console.WriteLine(enteredNumber.Key.ToString());
        switch (enteredNumber.Key.ToString())
        {
            case "D0":
                enteredSymbols[i] = "0";
                count++;
                break;
            case "D1":
                enteredSymbols[i] = "1";
                count++;
                break;
            case "D2":
                enteredSymbols[i] = "2";
                count++;
                break;
            case "D3":
                enteredSymbols[i] = "3";
                count++;
                break;
            case "D4":
                enteredSymbols[i] = "4";
                count++;
                break;
            case "D5":
                enteredSymbols[i] = "5";
                count++;
                break;
            case "D6":
                enteredSymbols[i] = "6";
                count++;
                break;
            case "D7":
                enteredSymbols[i] = "7";
                count++;
                break;
            case "D8":
                enteredSymbols[i] = "8";
                count++;
                break;
            case "D9":
                enteredSymbols[i] = "9";
                count++;
                break;
            default:
                enteredSymbols[i] = enteredNumber.Key.ToString();
                break;
        }
    }
    return (count, enteredSymbols);
}

// Исполнение программы
int numberM = ReadData("Введите число М: ");

// var result = PositiveNumbersCount(numberM);
// PrintResult($"Пользователь ввел ({ArrayIntToString(result.Item2)}) из них больше 0 -> {result.Item1}");
// Console.WriteLine();

// Исполнение программы *
var result = PositiveNumbersReadKey(numberM);
Console.WriteLine();
PrintResult($"Пользователь ввел ({ArrayStrToString(result.Item2)}) из них > 0 -> {result.Item1}");
Console.WriteLine();
