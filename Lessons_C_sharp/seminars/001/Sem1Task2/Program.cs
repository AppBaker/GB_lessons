//=============================================
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//=============================================

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Ввод денных, принимаем два значения
Console.WriteLine("Enter number A");
string? inputLineA = Console.ReadLine();
Console.WriteLine("Enter number B");
string? inputLineB = Console.ReadLine();

// Проверяем наличие значений
if (inputLineA != null && inputLineB != null)
{
    // Преобразуем string значение в int
    int numberA = int.Parse(inputLineA);
    int numberB = int.Parse(inputLineB);

    // При помощи ветвления определяем какое число больше или они равны
    if (numberA > numberB)
    {
        Console.WriteLine("Number A>B: " + numberA + " > " + numberB);
    }
    else if (numberB > numberA) 
    {
         Console.WriteLine("Number B>A:" + numberB + " > " + numberA);
    }
    else
    {
        Console.WriteLine("Number A=B: " + numberA + " = " + numberB);
    }
}