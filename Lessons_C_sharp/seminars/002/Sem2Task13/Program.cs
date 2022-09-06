//=============================================
// #13 Напишите программу, которая выводит третью цифру заданного
//  числа или сообщает, что третьей цифры нет.
//=============================================
// Учимся структурированному программированию

// Глобальные переменные
Console.WriteLine("Программа выводит третью цифру заданного числа, если она есть");
string inputLine = "";
string result = "";

// Вводим данные
void ReadData()
{
    Console.WriteLine("Введите число");
    inputLine = Console.ReadLine();
}

// Преобразование данных и выделение второй цифры
void CalculateData()
{
    if (inputLine.Length > 2)
    {
        char[] charArray = inputLine.ToCharArray();
        result = charArray[2].ToString();
    }
    else if (inputLine.Length < 3)
    {
        result = "третьей цифры нет";
    }
}
// Выводит результат
void PrintData()
{
    Console.WriteLine(inputLine + " -> " + result);
}

// =====================================================

// Вызов функций
ReadData();
CalculateData();
PrintData();