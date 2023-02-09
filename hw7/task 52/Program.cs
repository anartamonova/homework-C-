// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк, m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов, n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++) {
  for (int j = 0; j < arr.GetLength(1); j++) {
    arr[i, j] = new Random().Next(0,10);
    Console.Write($"{arr[i, j]} ");
  }
  Console.WriteLine();
};
        
Console.Write("Среднее арифмитическое каждого столбца: ");      
double[] sum = new double[n];
for (int z = 0; z < arr.GetLength(1); z++) {
  for (int k = 0; k < arr.GetLength(0); k++) {
    sum[z] = sum[z]+ arr[k,z];
  }
  sum[z] = Math.Round((sum[z] / arr.GetLength(0)), 2);
  Console.Write($"{sum[z]}; ");
}