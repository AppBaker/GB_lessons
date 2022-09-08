//=============================================
// #15 Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//=============================================
// Учимся структурированному программированию

// Глобальные переменные
Console.WriteLine("Программа выводит является ли день выходным");
string inputLine = "";
int day = 0;
int exitCode = 0;
// Создаем словарь
Dictionary<int, string> daysOfWeek =
    new Dictionary<int, string>();
// Заполняем словарь
daysOfWeek.Add(1, "Рабочий");
daysOfWeek.Add(2, "Рабочий");
daysOfWeek.Add(3, "Рабочий");
daysOfWeek.Add(4, "Рабочий");
daysOfWeek.Add(5, "Рабочий");
daysOfWeek.Add(6, "Выходной");
daysOfWeek.Add(7, "Выходной");


// Вводим данные
void ReadData()
{
    Console.WriteLine("Введите число/день недели (1-7) или q для выхода");
    inputLine = Console.ReadLine();
}

// Преобразование данных и выделение второй цифры
void CheckDay()
{
    // Проверяем есть ли значение
    if (inputLine != null)
    {
        // проверяем ввел ли пользователь q для выхода
        if (inputLine.ToLower() != "q")
        {
            int inpupNumber = int.Parse(inputLine);
            // проверяем правильно ли введен номер дня недели
            // если нет то просим повторить ввод
            // if (inpupNumber > 0 && inpupNumber < 8)
            if (daysOfWeek.ContainsKey(inpupNumber))
            {
                day = inpupNumber;
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число)");
                ReadData();
                CheckDay();
            }
        }
    }
}

// Выводит результат
void PrintData()
{
    if (day != 0)
    {
        Console.WriteLine(day + " -> " + daysOfWeek[day]);
    }
    else
    {
        Console.WriteLine("Вы вышли из программы");
    }
}

// =====================================================
// Вызов функций
ReadData();
CheckDay();
PrintData();