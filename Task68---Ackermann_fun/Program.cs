// Задача 68: 
//     Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//     Даны два неотрицательных числа m и n. 
//         m = 2, n = 3 -> A(m,n) = 9

int WilhelmFriedrichAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return WilhelmFriedrichAckermann(m - 1, 1);
    else return WilhelmFriedrichAckermann(m - 1, WilhelmFriedrichAckermann(m, n - 1));
}

System.Console.Write("Введите два числа через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int Péter = Math.Abs(lazyWrite[0]);
int Rózsa = Math.Abs(lazyWrite[1]);
System.Console.WriteLine(WilhelmFriedrichAckermann(Péter, Rózsa));


// кроме того, нашёл вариант решения, пока не понимаю, но оставил себе на разобраться:
System.Console.WriteLine(ack(Péter, Rózsa));

int ack(int n, int m) {
    while (n != 0) {
        if (m == 0)
            m = 1;
        else
            m = ack(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}