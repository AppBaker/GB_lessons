//=============================================
// #3 Напишите программуб которая будет 
// выдавать название дня недели по заданному номеру 
//=============================================

Console.WriteLine("Enter number of Day");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);
    // MASSIV
    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "Monday";
    // dayOfWeek[1] = "Tuesday";
    // dayOfWeek[2] = "Wednesday";
    // dayOfWeek[3] = "Thursday";
    // dayOfWeek[4] = "Friday";
    // dayOfWeek[5] = "Saturday";
    // dayOfWeek[6] = "Sunday";

    // if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    // {
    //     Console.WriteLine("Index out of range, there is not such day");
    // }
    // else
    // {
    //     Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
    // }

    // SWITCH STATEMENT
    string outDayOfWeek = "";

    switch (inputDayOfWeek)
    {
        case 1:
            outDayOfWeek = "Monday";
            break;
        case 2:
            outDayOfWeek = "Tuesday";
            break;
        case 3:
            outDayOfWeek = "Wednesday";
            break;
        case 4:
            outDayOfWeek = "Thursday";
            break;
        case 5:
            outDayOfWeek = "Friday";
            break;
        case 6:
            outDayOfWeek = "Saturday";
            break;
        case 7:
            outDayOfWeek = "Sunday";
            break;
        default:
            outDayOfWeek = "Index out of range, there is not such day";
            break;
    }
    Console.WriteLine(outDayOfWeek);

}