// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение1: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x==1) {
    Console.Write($"Понедельник");
};
if (x==2) {
    Console.Write($"Вторник");
};
if (x==3) {
    Console.Write($"Среда");
};
if (x==4) {
    Console.Write($"Четверг");
};
if (x==5) {
    Console.Write($"Пятница");                         
};
if (x==6) {
    Console.Write($"Суббота");
};
if (x==7) {
    Console.Write($"Воскресенье");
};

if (x>7){
    Console.Write($"В неделе всего 7 дней");
};

