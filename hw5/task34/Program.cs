//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите число элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.Write("[");
  for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(100,999);
    Console.Write($"{array[i]} ");
    };
Console.Write("] -> ");
int sumN = 0;
  for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0){
      sumN =sumN + 1;
    };
  };
Console.Write(sumN);
