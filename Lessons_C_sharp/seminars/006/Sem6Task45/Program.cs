//=============================================
// // #45  Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.
//=============================================

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }

    return newArray;
}

