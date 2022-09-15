//=============================================
// #33 Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder = 0, int topBorder = 10)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    int[] arr = new int[num];
    //Тест границ
    if (downBorder > topBorder)
    {
        int temp = downBorder;
        downBorder = topBorder;
        topBorder = temp;
    }
    //Заполняем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = numSintezator.Next(downBorder, topBorder + 1);
    }
    //Возвращаем результат
    return arr;
}

//Печатает одномерный массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

bool FindElementIn(int[] array, int number)
{
    if (array.Contains(number))
    {
        return true;
    }
    else
    {
        return false;
    }

}

int arrayLenth = ReadData("Введите длину массива");
int[] array = FillArray(arrayLenth);
// Print1DArr(array);

int findNumber = ReadData("Введите число для поиска в массиве");

bool result = FindElementIn(array, findNumber);

if (result)
{
    Console.Write($"{findNumber}" + "; массив ");
    Print1DArr(array);
    Console.Write(" -> Да");
}
else
{
    Console.Write($"{findNumber}" + ";");
    Print1DArr(array);
    Console.Write(" -> Нет");
}

Console.WriteLine("[{1} & {0}]", "Hello", "Dolly");





