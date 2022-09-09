//=============================================
// #17 Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//=============================================

int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    // Создаем массив данных который будем возвращать
    // int[] data = new int[countOfEnters];
    //Считываем число
    // for (int i = 0; i < countOfEnters; i++)
    // {
    //     data[i] = int.Parse(Console.ReadLine() ?? "0");
    // }
    //Возвращаем значение
    // return data;

    return int.Parse(Console.ReadLine() ?? "0");
}

int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0)
    return 1;
    if (x < 0 && y > 0)
    return 2;
    if (x < 0 && y < 0)
    return 3;
    if (x > 0 && y < 0)
    return 4;

    return -1;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Исполнение программы

int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");

PrintResult("Точка находится в четверти: #" + QuarterTest(x, y));

