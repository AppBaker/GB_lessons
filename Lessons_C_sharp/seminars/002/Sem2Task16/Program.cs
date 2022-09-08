//=============================================
// #16 Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.
//=============================================


// чтение данных из сонсоли
string ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    
    string number = Console.ReadLine();
    Console.WriteLine("То что мы передали: " + "#" + number + "#");
    Console.WriteLine(number.GetType());
    //Возвращаем значение
    return number;
}

Console.WriteLine(ReadData("Enter some number"));
