// See https://aka.ms/new-console-template for more information
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
  for (int i = 1; i <= n; i++) {
    int nCubed = i*i*i;
    Console.WriteLine(nCubed);
    };
