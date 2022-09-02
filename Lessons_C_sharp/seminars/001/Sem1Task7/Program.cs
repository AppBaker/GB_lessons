//=============================================
// #7 Напишите программу которая на вход принимает трехзначное число
// и на выходе показывает последнюю цифру этого числа.
//=============================================

Console.WriteLine("Enter 3x number");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        int lastDigit = inputNumber % 10;
        Console.WriteLine("Last digit: " + lastDigit);
    }

}