//=============================================
// #18 Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
//=============================================

int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

string BorderTest(int number)
{
    if (number == 1)
    return "X > 0 and X > 0";
    if (number == 2)
    return "X < 0 and Y > 0";
    if (number == 3)
    return "X < 0 and y < 0";
    if (number == 4)
    return "X > 0 and Y < 0";

    return "-1";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Исполнение программы

int number = ReadData("Введите номер четверти[1-4]:");

PrintResult($"Диапазон координат X,Y в четверти: #{number}: " + BorderTest(number));




