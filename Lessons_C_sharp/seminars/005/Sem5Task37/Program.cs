//=============================================
// #37 Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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
int[] FillArray(int num, int downBorder = 1, int topBorder = 4)
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
    Console.WriteLine("[{0}]", string.Join(",", arr));
}
// Создание массива произведения двух чисел
int[] MultiplArray(int[] array)
{
    int halfLenthArray = array.Length / 2;
    int lenthArray = array.Length - 1;
    int[] multArray = new int[halfLenthArray];

    for (int i = 0; i < halfLenthArray; i++)
    {
        int newElement = array[i] * array[lenthArray - i];
        multArray[i] = newElement;
    }
    return multArray;
}

// Поиск элементов в массиве в заданном диапазоне



// Исполнение прогораммы
int arrayLenth = ReadData("Введити длину массива");
int[] array = FillArray(arrayLenth);
Print1DArr(array);
Print1DArr(MultiplArray(array));
