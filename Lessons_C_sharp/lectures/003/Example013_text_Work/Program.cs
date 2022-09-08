//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, // маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

// Ясна ли задача?

string text = "Я думаю, — сказал князь, улыбаясь, — что, ”ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += text[i].ToString();
    }
    
    return result;
}

Console.WriteLine(Replace(text, " ".ToCharArray()[0], "_".ToCharArray()[0]));
// Console.WriteLine(Replace(text, "с".ToCharArray()[0], "С".ToCharArray()[0]));
