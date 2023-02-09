// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Write("Введите строку элмента: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[new Random().Next(10) , new Random().Next(3,10)];
if(x >= 0 && y >=0){
 if(x <= arr.GetLength(0) && y <=arr.GetLength(1)){
  for (int i = 0; i < arr.GetLength(0); i++) {
    for (int j = 0; j < arr.GetLength(1); j++) {
      arr[i, j] = new Random().Next(0,10);
      Console.Write($"{arr[i, j]} ");
    }
   Console.WriteLine();
  }

  for (int z = 0; z < arr.GetLength(0); z++){
    if(z == x){
      for(int d = 0; d < arr.GetLength(1); d++){
        if(d == y){
          Console.WriteLine("Элемент массива с заданной позицией равен " + arr[z, d]);
        };
       } 
    };
  };
  } else {
    Console.WriteLine("Такого элемента в массиве нет");
    };
}
else {
    Console.WriteLine("Строка или столбец искомого элемента должен быть не меньше 0");
}