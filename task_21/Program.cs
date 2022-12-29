/*Напишите программу, которая принимает на вход
 координаты двух точек и находит расстояние между ними в 3D пространстве.*/
Console.WriteLine("Введите координаты точки X ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y ");
int Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Z ");
int Z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки X1 ");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y1 ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Z1 ");
int Z1 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2) + Math.Pow(Z1-Z, 2));

Console.WriteLine($"Расстояние между точками =  {Math.Round(res,2)}");
