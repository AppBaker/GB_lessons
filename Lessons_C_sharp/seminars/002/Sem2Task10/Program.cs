//=============================================
// #10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
//  показывает вторую цифру этого числа.
//=============================================
// Учимся структурированному программированию


// Вариант 1

// Глобальные переменные
string inputLine = "";
int result = 0;

// Вводим данные
void ReadData()
{
    Console.WriteLine("Введите трехзначное число");
    inputLine = Console.ReadLine();
}

// Преобразование данных и выделение второй цифры
void CalculateData()
{
    if (inputLine != null)
    {
        int number = int.Parse(inputLine);
        result = (number / 10) % 10;
    }
    else
    {
        // Если ввели не трехзначное число, просим ввести другое число
        Console.WriteLine("You entered an invalid number, please try again.");
        ReadData();
        CalculateData();
    }
}

// Выводит результат
void PrintData()
{
    Console.WriteLine("Вторая цифра: " + result);
}



// // Вариант 2
// // Глобальные переменные
// string inputLine = "";
// string result = "";

// // Вводим данные
// void ReadData()
// {
//     Console.WriteLine("Введите трехзначное число");
//     inputLine = Console.ReadLine();
// }

// // Преобразование данных и выделение второй цифры
// void CalculateData()
// {
//     if (inputLine != null && inputLine.Length == 3)
//     {
//         char[] charArray = inputLine.ToCharArray();
//         result = charArray[1].ToString();
//     }
//     else
//     {
//         // Если ввели не трехзначное число, просим ввести другое число
//         Console.WriteLine("You entered an invalid number, please try again.");
//         ReadData();
//         CalculateData();
//     }
// }
// // Выводит результат
// void PrintData()
// {
//     Console.WriteLine("Вторая цифра: " + result);
// }

// =====================================================

// Вызов функций
ReadData();
CalculateData();
PrintData();