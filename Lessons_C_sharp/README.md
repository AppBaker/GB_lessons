## C# Syntax

```
dotnet new console - создать новый проект
```

```
dotner run - запуск проекта
```

C# это строго типизированный язык, при создании переменной в начале указывается тип, потом название переменной. В конце каждой значащей строки кода ставится точка с запятой ;.
```
string mewStrung = "Hello new string";
```

### Случайное число из диапазона [x, y)
```
int number = new Random().Next(x, y);
```
### Math
```
int maxNumber = Math.Max(numA, numB);
```


### Вывод в консоли текста
```
Console.WriteLine("Hello World!");
Console.Write("Hello World!");
```
### Комментарии
```
// Комментарий обозначается "//" в начале каждой строки комментария
```
### Функции
```
// Возвращаемый_тип имя_функции(тип_аргумента имя_аргумента)

double funcName(double x)
{
double result = x * x + 1;
return result;
}
```
Функция которая ни чего не возвращает
```
void funcName(double x)
{
double result = x * x + 1;
}
```

### Массив

```
Тип данных[]ИМЯ = {Значение1, Значение2, ...}
int[] array = {1,2,3,4,5,45,5765}
```
```
int[] array = {0,0,0,0,0}
int[] array = new int[5];
int[] array = new int[]{0,0,0,0,0,0};
int[] array = new int[5]{0,0,0,0,0,0};
```
```
array[0] -> обращаемся к 0 элементу массива
```
Методы массива:
```
array.Length -> количество элементов в массиве

```
## Двумерные массивы
```
string[,] table = new string[2,3];
2 - строки
3 - столбцы
```
```
int[,] matrix = int[5,8];
5 - строки
8 - столбцы
```
```
table.GetLenth(0) -> количество строк
table.GetLenth(1) -> количество столбцов
```

### Тернарный оператор

```
(условие) ? <значение 1> : < значение 2>
```
## Типы данных
```
int A = 5; 4 байта
```
```
long A = 5; 8 байт
```
```
short A = 5; 1 байт
```
```
bool A = true/false; 1 байт
```
```
string A = "Hello"; 12 байт и разростается
```
```
char A = "j"; 2 байта
```
## ЦИКЛЫ

while:
```
while (condition)
{
    Console.WriteLine("Текст будет повторяться пока condition == true");
}
```

for:
```
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Текст будет повторяться lenth раз");
}
```

# Работа с текстом
## Табуляция \t
```
string text = "Some text" + "\t" + "text"
```