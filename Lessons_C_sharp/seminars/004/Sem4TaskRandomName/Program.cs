//=============================================
// Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
//=============================================

//Запрос данных у пользователя
// Возвращаем кортеж для проверки наличия значения имени
(string, bool) ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    string result = Console.ReadLine() ?? "No Names, fatal error :)";
    if (result == "") return ("Вы не ввели ни одного имени!", false);
    return (result, true);
}

// Разделяем имена и возвращаем случайное
string GetRandomName(string names)
{
    string[] namesArray = names.Split(",");
    Random random = new Random();
    return namesArray[random.Next(0, namesArray.Length)];
}

// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}
 
// Выполнение программы
// Собираем кортеж чтобы проверять ввел ли пользователь хотябы одно имя
(string, bool) names = ReadData("Введите имена игроков через запятую (Ваня, Слава, Катя, Тима, Коля...)");
// Проверяем ввел ли пользователь данные
if (names.Item2)
{
    PrintResult($"Отлично! Выйграл {GetRandomName(names.Item1)}");
}
else
{
    PrintResult($"{names.Item1}");
}

