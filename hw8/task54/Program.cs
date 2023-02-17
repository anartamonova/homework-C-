// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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
        
Console.WriteLine("Упорядоченный массив: ");      

for (int z = 0; z < arr.GetLength(0); z++) {
  for (int k = 0; k < arr.GetLength(1); k++) {
    int max = arr[z,k];
    for (int count = k+1; count < arr.GetLength(1); count++) {

    if (arr[z,count] > max)
            {
            max = arr[z,count];
            arr[z,count] = arr[z,k];
            arr[z,k] = max;
            }
        }    
    
    Console.Write($"{arr[z, k]} ");
    }
    Console.WriteLine();
}