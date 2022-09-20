//=============================================
// #39  Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.
//=============================================

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}
//Метод разварота массива и создание нового массива
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}

//Метод разварота заданного массива
int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}


int[] arr = GenArray(20, 1, 100);
Console.WriteLine("Исходный массив:");
PrintArray(arr);

int[] copyArray = SwapNewArray(arr);
Console.WriteLine("Новый перевернутый массив:");
PrintArray(copyArray);
Console.WriteLine("Исходный массив:");
PrintArray(arr);

arr = SwapArray(arr);
Console.WriteLine("Перевернутый исходный массив:");
PrintArray(arr);

