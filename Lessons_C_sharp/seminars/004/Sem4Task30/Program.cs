//=============================================
// #30 Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// Например: [1,0,1,1,0,1,0,0]
 
//=============================================

//Запрос данных у пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Произведение чисел
int[] RandomArray(int number)
{
    int[] randomArray = new int[number];
    Random random = new Random();
    for (int i = 0; i < number; i++)
    {
        randomArray[i] = random.Next(0,2);
    }

    return randomArray;
}


// Вывод результата
void PrintArray(int[] array)
{
    string stringArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        stringArray += array[i].ToString();
        stringArray += ",";
    }
    Console.WriteLine(stringArray);
}

PrintArray(RandomArray(ReadData("Enter number")));


