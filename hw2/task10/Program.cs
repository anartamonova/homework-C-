Console.Write("Введите значение N: ");
int x = Convert.ToInt32(Console.ReadLine());
int length = x.ToString().Length;
int y = 0;
if (length == 3)
{
    y = (x % 100) / 10;
    Console.WriteLine(y);
}
else 
{
    Console.WriteLine("Введите трехзначное число");
}
