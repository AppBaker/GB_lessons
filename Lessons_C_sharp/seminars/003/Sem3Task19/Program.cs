//=============================================
// #19 Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
//=============================================

// Запрос данных
string ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    string result = Console.ReadLine() ?? "00000";
    return result;

}

// Определяем является ли строка любой длины палиндромом при помощи массива
// Метод1
bool PolindromTestMassiv(string number)
{
    bool result = false;
    char[] charArray = number.ToCharArray();
    Array.Reverse(charArray);
    string rewerseNumber = new string(charArray);
    Console.WriteLine(rewerseNumber);
    if (number == rewerseNumber) result = true;
    return result;
}
// Метод2 словарь(ключ 2 цифры + значение 2 цифры)
// ДЛЯ ПЯТИЗНАЧНОГО ПАЛИНДРОМА

bool? PolindromTestDict(string number)
{
    bool? result = null;
    int numberInt = int.Parse(number);
    // Проверяем на 5и значность
    if (numberInt > 9999 && numberInt < 100000)
    {
        // Создаем словарь
        Dictionary<int, int> polindromDict =
            new Dictionary<int, int>();
        // Заполняем словарь (ключ -> первые 2 цифры; значение -> последние две цифры палиндрома)
        for (int i = 10; i < 100; i++)
        {
            int ten = i / 10; //первая цифра
            int one = i % 10; // вторая цифра
            polindromDict.Add(i, (one * 10 + ten)); // добавляем значение в словарь
        }

        if (polindromDict.ContainsKey(numberInt / 1000) && numberInt % 100 == (polindromDict[numberInt / 1000]))
        {
            result = true;
        }
        else result = false;
    }
    else
    {
        Console.WriteLine("Число не является пятизначным");
    }
    return result;
}

// Метод 3 словарь (ключи->первые 2 цифры и последные две цифры палиндрома)
// ДЛЯ ПЯТИЗНАЧНОГО ПАЛИНДРОМА

bool? PolindromTestDict_(string number)
{
    bool? result = null;
    int numberInt = int.Parse(number);
    // Проверяем на 5и значность
    if (numberInt > 9999 && numberInt < 100000)
    {
        // Создаем словарь
        Dictionary<int, string> polindromDict = new Dictionary<int, string>();
        // Заполняем словарь (ключ -> первые2 и последние две цифры заданного числа)
        for (int i = 10; i < 100; i++)
        {
            int ten = i / 10; //первая цифра
            int one = i % 10; // вторая цифра
            polindromDict.Add((ten * 10000 + one * 1000 + one * 10 + ten), "Полиндром"); // добавляем значение в словарь
        }
        // Проверяем есть ли ключ в словаре
        if (polindromDict.ContainsKey(((numberInt / 1000) * 1000) + numberInt % 100))
        {
            // Если есть то число является палиндромом
            result = true;
        }
        else result = false;
    }
    else
    {
        Console.WriteLine("Число не является пятизначным");
    }
    return result;
}

// Выыод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Исполнение программы
string number = ReadData("Введите пятизначное число:");

// вызываем Метод1 massiv

Console.WriteLine($"Является ли число {number} полиндромом: " + (PolindromTestMassiv(number) ? "Да" : "Нет"));

// вызываем Метод2 dict
// Проверяем на null
if (PolindromTestDict(number) != null)
{
    bool newBool = PolindromTestDict(number) ?? false;
    Console.WriteLine($"Является ли число {number} полиндромом: " + (newBool ? "Да" : "Нет"));
}
// вызываем Метод3 dict1
// Проверяем на null
if (PolindromTestDict_(number) != null)
{
    bool newBool = PolindromTestDict_(number) ?? false;
    Console.WriteLine($"Является ли число {number} полиндромом: " + (newBool ? "Да" : "Нет"));
}






