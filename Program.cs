
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void FindDeap(int m, int n)
// {
// if (m <= n)
// {
// FindDeap(m, n - 1);
// Console.Write(n + ", ");
// }
// }

// Console.WriteLine("Input number of n");
// int n = Convert.ToInt32(Console.ReadLine());
// FindDeap(1, n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int Summ(int m, int n)
// {
// int sum = n;
// if (m != n)
// {
// if (m <= n)
// {
// return Summ(m, n - 1) + n;
// }
// else
// {
// return Summ(m - 1, n) + m;
// }
// }
// else return 0;
// }
// Console.WriteLine("Input number of m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of n");
// int n = Convert.ToInt32(Console.ReadLine());
// int x = Summ(m, n);
// Console.WriteLine(x);

 
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// void AkkermanFunct(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// Console.WriteLine("Input number of m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of n");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunct(m,n);