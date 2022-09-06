//=============================================
// #9 Напишите программу которая выводит случайное число из отрезка [10,99] 
// и показывает наибольшую цифру числа.
//=============================================

void VersionOne()
{
    Console.WriteLine("##########################");
    Console.WriteLine("Method 1");
    Console.WriteLine("##########################");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine("Random number: " + number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine("max digit: " + firstDigit);
    }
    else
    {
        Console.WriteLine("max digit: " + secondDigit);
    }
    Console.WriteLine("############ END ##############");
}
// Вариант с тернарным оператором
void VersionTwo()
{
    Console.WriteLine("##########################");
    Console.WriteLine("Method 1");
    Console.WriteLine("##########################");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine("Random number: " + number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    Console.WriteLine("Ternarn operator " + ((firstDigit > secondDigit) ? firstDigit : secondDigit));
    Console.WriteLine("############ END ##############");
}
//Вариант char
void charVersion()
{
    Console.WriteLine("##########################");
    Console.WriteLine("Method 1");
    Console.WriteLine("##########################");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);

    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine("Char method: " + (((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]));
    Console.WriteLine("############ END ##############");
}

VersionOne();
VersionTwo();
charVersion();