
// РЕКУРСИЯ

// цикл
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// Console.WriteLine(NumbersFor(1,10));

string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}
// Console.WriteLine(NumbersRec(1,10));

// Сумма чисел от 1 до n

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// Console.WriteLine(SumRec(2));

// Факториал
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
// Console.WriteLine(FactorialRec(10));

// Возведение в степень

int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

// Поиск слов по заданному количеству букв
int n = 1;
void FindVWords(string alphabet, char[] word, int lenth = 0)
{
    if (lenth == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenth] = alphabet[i];
        FindVWords(alphabet, word, lenth + 1);
    }
}

// FindVWords("ab", new char[3]);

// ОБХОД ДИРЕКТОРИИ
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "   ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = "/Users/appbaker/Documents/GeekBrains/LESSONS";

// CatalogInfo(path);

void Towers(string with = "1", string on = "3", string some = "2", int count = 2)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();