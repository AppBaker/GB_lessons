//=============================================
// #21 Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек
//=============================================

// Запрос данных
double[] ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    Console.Write("Coordinate x = ");
    double x = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Coordinate y = ");
    double y = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Coordinate z = ");
    double z = double.Parse(Console.ReadLine() ?? "0");
    return new double[] { x, y, z };

}

// * Ввод данных в строку
double[][] ReadData_()
{
    Console.WriteLine();
    Console.WriteLine("Введите координаты точек\nX(x,y,z) и Y(x,y,z) через запятую.\nМужду координатами X и Y поставьте пробел\nПример: 4,54,3 12,43,6: ");
    string coordinates = Console.ReadLine() ?? "0,0,0 0,0,0";
    // Разделяем строку на координаты X и Y
    string[] xyCoordinates = coordinates.Split(" ");

    // Разделяем координаты точки X на x,y,z
    string[] xCoordinates = xyCoordinates[0].Split(",");
    // Разделяем координаты точки Y на x,y,z
    string[] yCoordinates = xyCoordinates[1].Split(",");

    // Создаем массивы координат X и Y
    double[] xCor = new double[] { Convert.ToDouble(xCoordinates[0]), Convert.ToDouble(xCoordinates[1]), Convert.ToDouble(xCoordinates[2]) };
    double[] yCor = new double[] { Convert.ToDouble(yCoordinates[0]), Convert.ToDouble(yCoordinates[1]), Convert.ToDouble(yCoordinates[2]) };
    // Возвращаем массив в массиве [[x,y,x],[x,y,x]]
    return new double[][] { xCor, yCor };

}

// Вычисление растояния между двумя точками в 3D
double CalculateDistance(double[] x, double[] y)
{
    double distance = Math.Sqrt(Math.Pow(x[0] - y[0], 2) + Math.Pow(x[1] - y[1], 2) + Math.Pow(x[2] - y[2], 2));
    return distance;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Исполнение программы
// Вариант 1
// ReadData();
// double[] x = ReadData("Enter coordinates for X: ");
// double[] y = ReadData("Enter coordinates for Y: ");

// Вариант 2*
double[][] xy = ReadData_();
double[] x = xy[0];
double[] y = xy[1];


PrintResult("Distance betwen X and Y = " + Math.Round(CalculateDistance(x, y), 3));

