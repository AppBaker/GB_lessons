//=============================================
// #28 Напишите программу, которая принимает на вход
//  число N и выдаёт произведение чисел от 1 до N.
// Например: 4 -> 24
// 5 -> 120
 
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Произведение чисел
long MultA(int number)
{
    long multNum = 1;
    for (int i = 1; i <= number; i++)
    {
        multNum = multNum * i;
    }
    return multNum;
}
// Рекурсивный метод

long RecursMet(int num)
{
    if (num == 1) return 1;
    return num * RecursMet(num-1);
}

// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

PrintResult("Сумма чисел равна: " + MultA(ReadData("Enter number")));
PrintResult("Сумма чисел равна: " + RecursMet(ReadData("Enter number")));


