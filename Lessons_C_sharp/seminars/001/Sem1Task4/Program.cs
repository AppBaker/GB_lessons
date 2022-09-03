//=============================================
// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
//=============================================

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Ввод денных, принимаем три значения
Console.WriteLine("Enter number A");
string? inputLineA = Console.ReadLine();
Console.WriteLine("Enter number B");
string? inputLineB = Console.ReadLine();
Console.WriteLine("Enter number С");
string? inputLineС = Console.ReadLine();

// Проверяем наличие значений
if (inputLineA != null && inputLineB != null && inputLineС != null)
{
    // Преобразуем string значение в int
    int numberA = int.Parse(inputLineA);
    int numberB = int.Parse(inputLineB);
    int numberC = int.Parse(inputLineС);

    // ВАРИАНТ #1 с массивом
    // Создаем массив, сортируем его 
    // и выдаем последнее значение которое является максимальным
    // int[] numbers = {numberA, numberB, numberC};
    // Array.Sort(numbers);
    // Console.WriteLine("Max number = " + numbers.Last());
//=============================================
    // ВАРИАНТ #2 ветвление
    // При помощи ветвления определяем какое число больше
    if (numberA > numberB)
    {
        if (numberA > numberC)
             {
                Console.WriteLine("Number A = " + numberA + " max");
             }
             else
             {
                Console.WriteLine("Number C = " + numberC + " max");
             }

    }
    else 
    {
        if (numberB > numberC)
        {
            Console.WriteLine("Number B = " + numberB + " max");
        }
        else
        {
            Console.WriteLine("Number C = " + numberC + " max");
        }
    }
}