// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("введите координаты Xa: ");
int Xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты Ya: ");
int Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты Za: ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты Xb: ");
int Xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты Yb: ");
int Yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты Zb: ");
int Zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
Console.WriteLine($"{result:f2}");
