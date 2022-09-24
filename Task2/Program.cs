// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Write("Введите координаты точки X1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y1: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z1: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки X2: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y2: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z2: ");
int z1 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x,2) + Math.Pow(y1-y,2) + Math.Pow(z1-z,2));
Console.WriteLine($"Расстояние между точками равно  {result:f2}");


