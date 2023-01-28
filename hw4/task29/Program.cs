//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
  if (length <= 8) {
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++) {
      array[i] = new Random().Next(1,12);
      Console.Write(array[i]+ ", ");
    }
  }
  else {
        Console.Write("Количество элементов должно быть не больше 8");
    }
   
