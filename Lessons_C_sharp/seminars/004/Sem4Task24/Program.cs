//=============================================
// #24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например: 7 -> 28
// 4 -> 10
// 8 -> 36
 
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;

}

// Метод вывода результата
// Вариант1
int VariansSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++)   
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

// Вариант1
int VariansSumGause(int numA)
{
    return ((numA + 1) * numA)/2;
}

// Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int number = ReadData("Enter number");

PrintResult($"{number} -> {VariansSumSimple(number)}");
Console.WriteLine("Gause:");
PrintResult($"{number} -> {VariansSumGause(number)}");

