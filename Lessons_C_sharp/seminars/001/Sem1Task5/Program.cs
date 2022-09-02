//=============================================
// #5 Напишите программу которая на вход принимает одно число (N)
// а на выходе показывает все целые числа от -N до N
//=============================================

Console.WriteLine("Enter number N");
string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);
    if (numberN > 0)
    {


        int startNumberN = (-1) * numberN;

        while (startNumberN <= numberN)
        {
            Console.Write(startNumberN + ", ");
            startNumberN += 1;
        }
    }

}