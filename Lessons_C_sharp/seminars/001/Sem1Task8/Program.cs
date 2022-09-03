//=============================================
// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
//=============================================

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Ввод числа N
Console.WriteLine("Enter number N");
string? inputLineN = Console.ReadLine();

// Проверяем наличие значений
if (inputLineN != null)
{
    // Преобразуем string значение в int
    int number = int.Parse(inputLineN);
    int counter = 1;
    // Создаем пустую строку для добавления четных чисел
    string even_numbers = "";
    // При помощи цикла while перебираем все числа от 1 до N
    while (counter <= number)
    {
        // Выбираем четные числа
        if (counter % 2 > 0)
        {
            // Если нечетное то просто прибавляем счетчик
            counter += 1;
        }
        else
        {
            // Если четное то добавляем его в строку и прибавляем счетчик
            even_numbers = even_numbers + counter.ToString() + ", ";
            counter += 1;
        }
    }
    // Выводим результат
    Console.WriteLine(number.ToString() + " -> " + even_numbers);
}