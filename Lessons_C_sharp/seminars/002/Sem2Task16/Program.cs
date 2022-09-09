//=============================================
// #16 Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.
//=============================================

string condition = "Введите два числа чтобы проверить является ли одно число квадратом другого";

// чтение данных из консоли
int[] ReadData(string line, int countOfEnters)
{
    //Выводим сообщение
    Console.WriteLine(line);
    // Создаем массив данных который будем возвращать
    int[] data = new int[countOfEnters];
    //Считываем число
    for (int i = 0; i < countOfEnters; i++)
    {
        data[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    //Возвращаем значение
    return data;
}

bool CalculateData(string[] data)
{
    bool result = false;
    int num1 = int.Parse(data[0]);
    int num2 = int.Parse(data[1]);

    if (num1 * num1 == num2)
    {
        Console.WriteLine($"{num2} это квадрат {num1}");
        result = true;
    }
    else if (num2 * num2 == num1)
    {
        Console.WriteLine($"{num1} это квадрат {num2}");
        result = true;
    }
    else
    {
        Console.WriteLine($"{num1} & {num2} не являются квадратами друг друга");
    }
    return result;
}

bool SqrTest(int num1, int num2)
{
    if (num1 == num2*num2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintResult(int[] nums)
{
    if (SqrTest(nums[0], nums[1]))
    {
        Console.WriteLine($"{nums[0]} квадрат {nums[1]}");
    }
    else
    {
        Console.WriteLine($"{nums[0]} НЕ квадрат {nums[1]}");
    }
}



PrintResult(ReadData("Enter 2 digit", 2));