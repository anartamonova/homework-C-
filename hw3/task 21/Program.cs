// See https://aka.ms/new-console-template for more information
 Console.Write("Введите координаты точки А по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int X = x2 - x1;
int Y = y2 - y1;
int Z = z2 - z1;
  
    
double dist = Math.Round((Math.Sqrt(X*X + Y*Y + Z*Z)), 2);

Console.WriteLine(dist);
