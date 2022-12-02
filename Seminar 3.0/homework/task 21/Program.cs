// Напишите программу, которая принимает на вход Введите двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите Ax");
int Ax = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите Ay");
int Ay = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите Az");
int Az = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите Bx");
int Bx = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите By");
int By = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите Bz");
int Bz = Convert.ToInt32 (Console.ReadLine());

double distance = Math.Sqrt((Math.Pow((Ax-Bx),2))+(Math.Pow((Ay-By),2))+(Math.Pow((Az-Bz),2)));

Console.Write ("Расстояние между А и B = ");
Console.WriteLine ($"{distance:f2}");