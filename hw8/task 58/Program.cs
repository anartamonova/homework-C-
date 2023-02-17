// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк первой матрицы = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы = ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] arr1 = new int[a, b];
int[,] arr2 = new int[x, y];
Console.WriteLine("Матрица 1");
for (int i = 0; i < arr1.GetLength(0); i++) {
  for (int j = 0; j < arr1.GetLength(1); j++) {
    arr1[i, j] = new Random().Next(1,10);
    Console.Write($"{arr1[i, j]} ");
  };
  Console.WriteLine();
};

Console.WriteLine("Матрица 2");

for (int i = 0; i < arr2.GetLength(0); i++) {
  for (int j = 0; j < arr2.GetLength(1); j++) {
    arr2[i, j] = new Random().Next(1,10);
    Console.Write($"{arr2[i, j]} ");
  };
  Console.WriteLine();
};

Console.WriteLine("Произведение матриц");

int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
if (arr1.GetLength(1) == arr2.GetLength(0)) {
  for (int i = 0; i < arr3.GetLength(0); i++) {
    for (int j = 0; j < arr3.GetLength(1); j++) {
      arr3[i, j] = 0;
      for (int n = 0; n < arr1.GetLength(1); n++) {
        arr3[i, j] = arr3[i, j] + arr1[i, n] * arr2[n, j];
      }
    }
   }
for (int i = 0; i < arr3.GetLength(0); i++) {
  for (int j = 0; j < arr3.GetLength(1); j++) {
    Console.Write($"{arr3[i,j]} ");
  }
  Console.WriteLine();
}
} else {
    Console.Write("Число столбцов первой матрицы должно быть равно числу строк второй.");
}