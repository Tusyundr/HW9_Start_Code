// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

 int n;
    Console.Write("Введите значение N: ");
    n = Convert.ToInt32(Console.ReadLine());
   
    void PrintRange(int start, int end)
    {
        if (start > end)
        {
            PrintRange(start, end + 1);
            Console.Write(", ");
        }
        Console.Write(end);
    }

    PrintRange(n, 1);
    Console.WriteLine();

    