//=============================================
// #29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Создание массива
int[] GenerateArray(int lenthOfArray, int numMin, int numMax)
{
    int[] randomArray = new int[lenthOfArray];
    Random random = new Random();
    for (int i = 0; i < lenthOfArray; i++)
    {
        randomArray[i] = random.Next(numMin, numMax + 1);
    }

    return randomArray;
}


// Печать массива
void PrintArray(int[] array)
{
    string stringArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        stringArray += array[i].ToString();
        stringArray += ",";
    }
    Console.WriteLine("Ваш массив:");
    Console.WriteLine(stringArray);
}

// Выполнение программы
int lenthOgArray = ReadData("Введите длинну массива: ");
int numMin = ReadData("Введите минимальное значение числа в массиве: ");
int numMax = ReadData("Введите минимальное значение числа в массиве: ");

PrintArray(GenerateArray(lenthOgArray, numMin, numMax));