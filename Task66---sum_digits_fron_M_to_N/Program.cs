// Задача 66: Задайте значения M и N. Напишите программу, которая 
//     найдёт сумму натуральных элементов в промежутке от M до N.
//         M = 1; N = 15 -> 120
//         M = 4; N = 8. -> 30

int SumDigits(int m, int n)
{
    if (m > n) return 0;
    return m + SumDigits(m + 1, n);
    // return n + SumDigits(m, n-1);
}

System.Console.Write("Введите два числа через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int M = lazyWrite[0];
int N = lazyWrite[1];
if (M > N)
    System.Console.WriteLine(SumDigits(N, M));
System.Console.WriteLine(SumDigits(M, N));