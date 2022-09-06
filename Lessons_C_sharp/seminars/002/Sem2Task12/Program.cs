//=============================================
// #12 Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число некратно
// первому, то программа выводит о статок от деления.
//=============================================

void MyMethod()
{
    Console.WriteLine("Введите два числа, Если второе число некратно первому, то программа выводит о статок от деления");
    Console.WriteLine("Enter number A");
    string? inputLineA = Console.ReadLine();
    Console.WriteLine("Enter number B");
    string? inputLineB = Console.ReadLine();

    if (inputLineA != null && inputLineB != null)
    {
        int numberA = int.Parse(inputLineA);
        int numberB = int.Parse(inputLineB);
        Console.WriteLine("Number A: " + numberA + " Number B: " + numberB);

        bool R = (numberB % numberA == 0);

        if (R)
        {
            Console.WriteLine(numberB + " кратно " + numberA);
        }
        else
        {
            Console.WriteLine(numberB + " НЕ кратно " + numberA + " остаток от деления " + numberB % numberA);
        }
    }
}

// Структурное проргаммирование

// Global variabels
int numberA = 0;
int numberB = 0;
bool result = false;

// Получаем два числа от пользователя
void ReadData()

{
    Console.WriteLine("Введите два числа, Если второе число некратно первому, то программа выводит о статок от деления");
    Console.WriteLine("Enter number A");
    string? inputLineA = Console.ReadLine();
    Console.WriteLine("Enter number B");
    string? inputLineB = Console.ReadLine();

    if (inputLineA != null && inputLineB != null)
    {
        numberA = int.Parse(inputLineA);
        numberB = int.Parse(inputLineB);
    }
}


// Определяем кратность чисел
void CalculateData()
{
    result = (numberB % numberA == 0);
}

// Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine(numberB + " кратно " + numberA);
    }
    else
    {
        Console.WriteLine(numberB + " НЕ кратно " + numberA + " остаток от деления " + numberB % numberA);
    }
}

ReadData();
CalculateData();
PrintData();