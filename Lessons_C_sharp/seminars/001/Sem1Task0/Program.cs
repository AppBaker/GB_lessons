//=============================================
// #0  Напишите прорграмму которая на входе
// принимает число и выдает его квадрат. (число умноженное само на есебя)
//=============================================

Console.WriteLine("Enter number");
string? inputLine = Console.ReadLine();
Console.WriteLine(inputLine);

if (inputLine != null)
{
    int outNumber = 0;
    DateTime d1 = DateTime.Now;
    int inputNumber = int.Parse(inputLine);
    for (int i = 0; i < 10000000; i++)
    {
        outNumber = inputNumber * inputNumber;
    }
    DateTime d2 = DateTime.Now;
    Console.WriteLine(d2 - d1);


    // int outNumber = (int)Math.Pow(inputNumber, 2);

    Console.WriteLine(outNumber);
}