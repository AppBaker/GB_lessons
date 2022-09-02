//=============================================
// #1  Напишите прорграмму, которая на входе
// принимает два числа и проверяет, является ли первое число квадратом второго.
//=============================================

Console.WriteLine("Enter number A");
string? inputA = Console.ReadLine();

Console.WriteLine("Enter number B");

string? inputB = Console.ReadLine();


if (inputA != null && inputB != null)



{
    
    int numberA = int.Parse(inputA);
    int numberB = int.Parse(inputB);

    bool outResult = (numberA * numberA == numberB);

    Console.WriteLine(outResult);

    // if ((int)(numberB * numberB) == (int)numberA)
    // {
    //     Console.WriteLine(numberA + " is a " + numberB + " squared");
    // }
    // else
    // {
    //     Console.WriteLine("ERROR " + numberA + " is not the " + numberB + " squared");
    // }
}