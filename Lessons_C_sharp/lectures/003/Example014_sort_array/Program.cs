

int[] array = {2,423,546,567,867,65,45,3,1,123,21,23,34,45,56,6767,768,98,9,1,2,3,4,5,6,7};

Console.WriteLine(array);

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort(array);
PrintArray(array);