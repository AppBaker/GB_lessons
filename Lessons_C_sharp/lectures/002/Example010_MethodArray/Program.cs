
int[] array = { 1, 2, 3, 44, 5, 6, 7, 34 };

int n = array.Length;

int find = 44;
int index = 0;

while (index < n)
{
    
    if (array[index] == find)
    {
        Console.WriteLine("find: " + array[index] + " at index = " + index);
        break;
    }
    
    index ++;
Console.WriteLine(index);
}