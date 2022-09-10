//=============================================
// #20 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве. Например:
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
//=============================================

double[] ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    Console.Write("Coordinate x = ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Coordinate y = ");
    double y = double.Parse(Console.ReadLine());
    return new double[] {x,y};

}

double CalculateDistance(double[] x, double[] y)
{
    double distance = Math.Sqrt(Math.Pow(x[0]+y[0], 2) + Math.Pow(x[1]+ y[1], 2));
    return distance;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Исполнение программы

double[] x = ReadData("Enter coordinates for X: ");
double[] y = ReadData("Enter coordinates for Y: ");
PrintResult("Distance betwen X and Y = " + CalculateDistance(x, y));







