//=============================================
// // #43  Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    Console.Write(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Точка пересечения прямых
(double, double) CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x * k1 + b1;
    return (x, y);
}

// Вычисление растояния между двумя точками
double CalculateDistance((double, double) x, (double, double) y)
{
    double distance = Math.Sqrt(Math.Pow(x.Item1 - y.Item1, 2) + Math.Pow(x.Item2 - y.Item2, 2));
    return distance;
}

// Площадь треугольника по формуле Герона
double SquareOfTriangle((double, double) a, (double, double) b, (double, double) c)
{
    double ab = CalculateDistance(a, b);
    double bc = CalculateDistance(b, c);
    double ac = CalculateDistance(a, c);
    // Формула Герона
    // p - полупериметр
    double p = (ab + bc + ac) / 2;
    double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
    return square;
}

void PrintResult(string prefix, (double, double) data)
{
    Console.WriteLine(prefix + " " + data.ToString());
}


// Исполнение программы
// Console.WriteLine("Введите коэффициенты для уравнений:");
// Console.WriteLine("y = k1 * x + b1");
// Console.WriteLine("y = k2 * x + b2");
// double k1 = ReadData("k1 = ");
// double b1 = ReadData("b1 = ");
// double k2 = ReadData("k2 = ");
// double b2 = ReadData("b2 = ");

// PrintResult("Точка пересечения", CrossPoint(k1, b1, k2, b2));

// Исполнение программы *
Console.WriteLine("Введите коэффициенты для уравнений:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine("y = k3 * x + b3");
double k1 = ReadData("k1 = ");
double b1 = ReadData("b1 = ");
double k2 = ReadData("k2 = ");
double b2 = ReadData("b2 = ");
double k3 = ReadData("k3 = ");
double b3 = ReadData("b3 = ");

(double, double) a = CrossPoint(k1, b1, k2, b2);
(double, double) b = CrossPoint(k1, b1, k3, b3);
(double, double) c = CrossPoint(k2, b2, k3, b3);

Console.WriteLine($"Площадт треугольника равна -> {SquareOfTriangle(a, b, c)}");




