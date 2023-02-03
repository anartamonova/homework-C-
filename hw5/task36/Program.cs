//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите число элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.Write("[");
  for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(-100,100);
    Console.Write($"{array[i]} ");
    };
Console.Write("] -> ");
int sumN = 0;
  for (int i = 0; i < array.Length; i++){
    if (i % 2 == 1){
      sumN =sumN + array[i];
    };
  };
Console.Write(sumN);
