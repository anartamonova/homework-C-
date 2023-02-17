// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка



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
int min = 0;
int sumStr = SumN(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++) {
  int z = SumN(arr, i);
  if (sumStr > z){
    sumStr = z;
    min = i;
  }
}
    
int SumN(int[,] arr, int i){
  int sumStr = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++){
    sumStr = sumStr + arr[i,j];
  }
  return sumStr;
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {min}.");
