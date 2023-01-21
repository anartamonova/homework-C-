//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите значение N: ");
int x = Convert.ToInt32(Console.ReadLine());
int length = x.ToString().Length;
string z = x.ToString();

if (length > 2)
{
   
    Console.WriteLine(z[2]);
}
else 
{
    Console.WriteLine("Третей цифры нет");
}
