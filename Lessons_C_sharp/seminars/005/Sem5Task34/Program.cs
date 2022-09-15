//=============================================
// #34  Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123] -> 1
// * Отсортировать массив методом пузырька
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
// Создаем массив с трехзначными числами
int[] FillArray(int num, int downBorder = 100, int topBorder = 999)
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
int CountEvenNumbersIn(int[] array)
{
    int countEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEvenNumbers++;
        }
    }
    return countEvenNumbers;
}

//* Сортировка массива метод пузырька
int[] SortArrayBubbleMethod(int[] array)
{   
    int iterations = 0;
    // Проходим по массиву
    for (int j = 0; j < array.Length; j++)
    {
        bool splitNumbers = false;
        // После каждой итерации большее значение уходит вправо
        for (int i = 0; i < array.Length - 1 - j; i++)
        {   
            // Меняем местами, передвигая большее значение вправо
            if (array[i] > array[i + 1])
            {
                int split = array[i + 1];
                array[i + 1] = array[i];
                array[i] = split;
                splitNumbers = true;
            }
        }
        //  Если массив отсортирован и не было перемещений то выходим из цикла
        if (!splitNumbers)
        {
            break;
        }
    }
    return array;
}


// Исполнение прогораммы
int arrayLenth = ReadData("Введити длину массива");
int[] array = FillArray(arrayLenth);
Print1DArr(array);
PrintResult($"Количесто четных чисел в массиве: {CountEvenNumbersIn(array)}");
PrintResult("Сортируем массив пузырьком");
Print1DArr(SortArrayBubbleMethod(array));

