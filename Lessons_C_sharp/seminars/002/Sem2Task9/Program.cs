//=============================================
// #9 Напишите программуб которая выводит случайное число из отрезка [10,99] 
// и показывает наибольшую цифру числа.
//=============================================

System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(10, 100);
Console.WriteLine("Random number: " + number );

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

// Вариант с тернарным оператором
Console.WriteLine("Ternarn operator " + ((firstDigit>secondDigit)? firstDigit : secondDigit));

//Вариант char
char[] charArray = number.ToString().ToCharArray();
Console.WriteLine("Char method: " + (((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]));