// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int func(int m, int n) {
    if (m == 0)
      return n + 1;
    
    if (n == 0) 
      return func(m-1, 1);
    else
      return func(m - 1, func(m, n - 1));
}

Console.WriteLine("Result = " + func(m,n));