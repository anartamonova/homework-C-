// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк, m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов, n = ");
int n = Convert.ToInt32(Console.ReadLine());
if(m > 0 && n >0){
double[,] arr = new double[m, n];
 for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        arr[i, j] = new Random().NextDouble() * 30 - 10;
        Console.Write($"{Math.Round((arr[i, j]), 1)} ");
    }
    Console.WriteLine();
 }
} else {
    Console.WriteLine("Введите число строк и столбцов больше 0");
}