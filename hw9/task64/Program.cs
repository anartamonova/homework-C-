// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
// от N до 1
void count(int n) {
    if (n == 1) {
        Console.Write($"{n} ");
    } else {
        count(n-1);
        Console.Write($"{n} ");
        
    }
}

count(n);
Console.WriteLine();
// в обратном порядке
void count2(int n) {
    
    if (n == 1) {
        Console.Write($"{n} ");
    } else {
        Console.Write($"{n} ");
        count(n-1);
    }
}

count2(n);