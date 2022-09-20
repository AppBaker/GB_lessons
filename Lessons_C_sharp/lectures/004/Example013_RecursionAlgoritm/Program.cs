
int row = 10;
int stack = 50;

string[,] table = new string[row,stack];

// Console.WriteLine();

// for (int i = 0; i < table.GetLength(0); i++)
// {
//     for (int j = 0; j < table.GetLength(1); j++)
//     {
//         if(i == 7 && j == 5)
//         {
//             Console.Write($"{table[i,j]}1 ");
//         }
//         else Console.Write($"{table[i,j]}0 ");
//     }
//     Console.WriteLine();
// }


double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine(Fibonacci(i));
}
