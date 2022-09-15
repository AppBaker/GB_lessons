//=============================================
// #35 Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
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
int[] FillArray(int num, int downBorder = 0, int topBorder = 300)
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
    Console.WriteLine("[" + string.Join(",",arr) + "]");
}
// Проверка вхождения в диапазон([max:min])
bool TestInRange(int number, int min, int max)
{
    return (number >= min && number<=max) ? true : false;
}

// Поиск элементов в массиве в заданном диапазоне
int CountElementsFitRangeInArr(int[] array)
{
    int count = 0;

    foreach (int item in array)
    {
        if (TestInRange(item, 10, 99))
        {
            count += 1;
        }
    }
    return count;
}


// Исполнение прогораммы
int[] array = FillArray(123);

Print1DArr(array);
PrintResult($"Количество элементов [10:99] = {CountElementsFitRangeInArr(array)}");
