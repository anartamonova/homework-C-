//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.Write("Введите число: ");
int  N = Convert.ToInt32(Console.ReadLine());
int x = N;
int sumX = 0;

while (x > 0) {
int numX = x % 10;
x = x / 10;
sumX  = sumX + numX;
};
Console.WriteLine($"{N} --> {sumX}");
