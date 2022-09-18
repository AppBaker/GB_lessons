//=============================================
// #36  Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю
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
// Создаем массив с числами [0,10]
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
    Console.WriteLine("[{0}]", string.Join(",", arr));
}

// Считаем сумму нечетных элементов массива
int SumNotEvenPositionNumbersIn(int[] array)
{
    int sumOfNumbers = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOfNumbers += array[i];
    }
    return sumOfNumbers;
}

//* Поиск пар в массиве
string FindIterationNumbersIn(int[] array)
{
    // Создаем пустую строку для добавления парных значений
    string repeaitingNumbers = "";
    // Проходим по массиву
    for (int i = 0; i < array.Length; i++)
    {
        // Создаем счетчи
        int repeatCount = 0;
        // Проходим по оставшейся части массива после i
        for (int j = 1 + i; j < array.Length; j++)
        {
            // Находим совпадения
            if (array[i] == array[j] && array[i] != -1)
            {
                // Если находим совпадения то увеличиваем счетчик и присваеваем null чтобы исключить повторения
                array[j] = -1;
                repeatCount += 1;
            }
        }
        // Если есть повторения
        if (repeatCount != 0)
        {
            for (int c = 0; c <= repeatCount; c++)
            {
                // Добавляем в строку количество повторяющихся элементов
                repeaitingNumbers += $"{array[i].ToString()}, ";
            }
        }
    }
    return repeaitingNumbers;
}


// Исполнение прогораммы
int arrayLenth = ReadData("Введити длину массива");
int[] array = FillArray(arrayLenth);
Print1DArr(array);
PrintResult($"Сумма элементов, стоящих на нечётных позициях: {SumNotEvenPositionNumbersIn(array)}");
PrintResult("\n==========ПОИСК ПАР В МАССИВЕ==========\n");
PrintResult($"Массив содержит повторяющиется цифры: {FindIterationNumbersIn(array)}");
