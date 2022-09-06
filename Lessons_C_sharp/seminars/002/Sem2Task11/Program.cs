//=============================================
// #11 Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
//=============================================

int TakeSecondDigit()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);

    int secondDigit = (number % 100) / 10;
    return secondDigit;
}

void RemoveSecondDigit()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);

    int firstDigit = number / 100;
    int thirdDigit = number % 10;

    Console.WriteLine(firstDigit * 10 + thirdDigit);
}
Console.WriteLine("First variant");
RemoveSecondDigit();

void CharVariant()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);

    char[] chars = number.ToString().ToCharArray();
    Console.WriteLine("" + chars[0] + chars[2]);
    // Console.WriteLine(chars[2]);

}

Console.WriteLine("Char variant");
CharVariant();
