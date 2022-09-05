
int[] array = new int[10];

void FillArray(int[] collection)
{
    int lenth = collection.Length;
    int index = 0;
    while (index < lenth)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(array[position] + ", ");
        position ++;
    }
}

void IndexOf(int[] array, int find)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        if (array[index] == find)
        {   
            Console.WriteLine("");
            Console.WriteLine("find: " + array[index] + " at index = " + index);
            break;
        }
        index ++;
    }
}


FillArray(array);
PrintArray(array);
IndexOf(array, 5);

// int n = array.Length;

// int find = 44;
// int index = 0;

// while (index < n)
// {
    
//     if (array[index] == find)
//     {
//         Console.WriteLine("find: " + array[index] + " at index = " + index);
//         break;
//     }
    
//     index ++;
// Console.WriteLine(index);
// }