//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Write("Введите число элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.Write("[");
  for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(100);
    Console.Write($"{array[i]} ");
    };
Console.Write("] -> ");
int a = array.Min();
int b = array.Max();
int diff = b -a;
Console.Write(diff);
