//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру: ");
int x = Convert.ToInt32(Console.ReadLine());
int length = x.ToString().Length;
if (length == 1) {
    if (x == 6 || x == 7) {
     Console.WriteLine("Выходной день");
    }
    else {
        Console.WriteLine("Рабочий день");
    }
}
else 
{
    Console.WriteLine("Введите число от 1 до 7");
}
