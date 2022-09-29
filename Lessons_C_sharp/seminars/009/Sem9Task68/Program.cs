//=============================================
// #68  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}
// Функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m-1, 1);
    return Akkerman(m-1, Akkerman(m, n-1));
}

// Исполнение программы
Console.WriteLine("Введите два неотрицательных числа");
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

PrintResult($"{Akkerman(m, n)}");