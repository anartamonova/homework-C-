// *Напишите программу, которая на вход принимает два числа и выдаёт,
// *какое число большее, а какое меньшее.
// * a = 5; b = 7 -> max = 7
// * a = 2 b = 10 -> max = 10
// * a = -9 b = -3 -> max = -3 
Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.WriteLine("Большее число = " + x);
    Console.WriteLine("Меньшее число = " + y);
}
else 
{
    Console.WriteLine("Большее число = " + y);
    Console.WriteLine("Меньшее число = " + x);
}