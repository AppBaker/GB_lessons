//=============================================
// #14 Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
//=============================================

void MyMethod()
{
    Console.WriteLine("Введитесчисло, программа проверит кратно ли оно одновременно 7 и 23");
    Console.WriteLine("Enter number");
    string? inputLine = Console.ReadLine();

    if (inputLine != null)
    {
        int number = int.Parse(inputLine);

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine(number + " кратно 7 и 23");
        }
        else
        {
        Console.WriteLine(number + " НЕ кратно 7 и 23");
        }
    }
}

MyMethod();



