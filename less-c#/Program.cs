// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение2: ");
int y = Convert.ToInt32(Console.ReadLine());

int res = y*y;
if (x==res) {
    Console.Write($" Число {x} является квадратом {y}");
}
else {
    Console.Write($" Число {x} не является квадратом {y}");
}
