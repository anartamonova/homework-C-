// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение N: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = -x;
while (y <= x)
{
    Console.Write(y + " ");
    y++;
};