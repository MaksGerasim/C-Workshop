// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
//d = √ (х А – х В) 2 + (у А – у В) 2

Console.WriteLine ("введите Ax");
int Ax = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("введите Ay");
int Ay = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("введите Bx");
int Bx = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("введите By");
int By = Convert.ToInt32 (Console.ReadLine());


double distX = Math.Pow((Ax-Bx),2);
double distY = Math.Pow((Ay-By),2);
double dist = Math.Sqrt(distX + distY);

Console.WriteLine ($"{dist:f2}");