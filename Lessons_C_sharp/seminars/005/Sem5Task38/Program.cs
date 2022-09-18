//=============================================
// #38  Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
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
// Создаем массив с целыми числами [0,100]
int[] FillIntArray(int num, int downBorder = 0, int topBorder = 100)
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
//Универсальный метод генерации и заполнения массива
// Создаем массив с вещественными числами [0,100]

double[] FillDoubleArray(int num, int downBorder = 0, int topBorder = 100, int round = 1)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    double[] arr = new double[num];
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
        arr[i] = Math.Round(numSintezator.NextDouble() * numSintezator.Next(downBorder, topBorder + 1), round);
    }
    //Возвращаем результат
    return arr;
}

//Печатает одномерный массив
void Print1DDoubleArr(double[] arr)
{
    Console.WriteLine("[{0}]", string.Join("; ", arr));
}

//Печатает одномерный массив
void Print1DIntArr(int[] arr)
{
    Console.WriteLine("[{0}]", string.Join("; ", arr));
}

//MIN MAX элеиенты массива
double MaxSubMinElemtntsOf(double[] array)
{
    // Считаем что первоезначение это и max & min
    double minElement = array[0];
    double maxElement = array[0];
    // Если присваивать int.MaxValue & int.MinValue 
    // то мы не найдем максимальное и минимальное число в массиве

    for (int i = 0; i < array.Length; i++)
    {
        if (minElement > array[i])
        {
            minElement = array[i]; // Присваиваем новое значение min
        }
        if (maxElement < array[i])
        {
            maxElement = array[i]; // Присваиваем новое значение max
        }
    }
    // Округляем полученное значение и возвращаем
    return Math.Round(maxElement - minElement, 2);
}

// Метод перемещает элементы массива со смещением
// fromPos - переместить с позиции
// toPosition - куда переместить 
void MoveArray(int[] array, int fromPos, int toPosition)
{
    int temp = 0;
    int tempNext = 0;
    for (int i = toPosition - 1; i < fromPos; i++)
    {
        if (i == toPosition - 1)
        {
            temp = array[i];
            array[i] = array[fromPos - 1];
        }
        else
        {
            tempNext = array[i];
            array[i] = temp;
            temp = tempNext;
        }
    }
}

// Сортировка массива методом вставки
int[] SortByPustMethod(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        //  проходим по массиву слева от элемента i
        for (int j = 0; j < i; j++)
        {
            if (array[i] <= array[j])
            {
                MoveArray(array, i + 1, j + 1);
            }
        }
    }
    return array;
}

// Сортировка массива методом подсчета
int[] SortByCountMethod(int[] array, int downBorder, int topBorder)
{
    // Создаем массив счетчиков в диапазоне значений массива
    int[] counts = new int[(topBorder + 2) - downBorder];

    for (int i = 0; i < array.Length; i++)
    {
        // Прибавляем счетчик значений
        counts[array[i]] += 1;
    }
        // Переводим счетчики в значения массива
    int counter = 0; 
    for (int j = 0; counter < array.Length; j++)
    {
        int numberCount = counts[j];

        for (int d = 0; d < numberCount; d++)
        {
            array[counter] = j;
            counter ++;
        }
    }
    return array;
}


// Исполнение прогораммы

int arrayLenth = ReadData("Введити длину массива");
// double[] array = FillDoubleArray(arrayLenth);
// Print1DDoubleArr(array);
// PrintResult($"Разница (Max - Min) -> {MaxSubMinElemtntsOf(array)}");

// Исполнение прогораммы *

int downBorder = ReadData("Введити минимальное значение");
int topBorder = ReadData("Введити максимальное значение");
int[] intArray = FillIntArray(arrayLenth, downBorder, topBorder);
int[] oneArray = intArray;
int[] twoArrey = intArray;
Print1DIntArr(intArray);
PrintResult("Сортировка Вставкой");
DateTime d1 = DateTime.Now;
// Сортировка вставкой
Print1DIntArr(SortByPustMethod(oneArray));
Console.WriteLine(DateTime.Now - d1);
// Сортировка подсчетом
PrintResult("Сортировка Подсчетом");
DateTime d2 = DateTime.Now;
Print1DIntArr(SortByCountMethod(twoArrey, downBorder, topBorder));
Console.WriteLine(DateTime.Now - d2);





