
// Type1 Ни чего не принимают и не возвращают переменные

void SomeMethod()
{
    Console.WriteLine("\n Created by AppBaker");
}

SomeMethod();

// Type2 Принимет аргументы и ни чего не возвращает 

// Type3 Не принимает аргументы и возвращает переменны

// Type4 Принимает и возвращает переменные

string RepeatText (int count, string text)
{   
    string result = string.Empty;
    int i = 0;
    while (i < count)
    {
        result = result + " #" + (i + 1).ToString() + " " + text;
        i++;
    }
    return result;
}

Console.WriteLine(RepeatText(count: 5, text: "Hello It's me"));

