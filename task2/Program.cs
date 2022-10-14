// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Clear();

double Distance (int x1, int y1, int x2, int y2, int z1, int z2)
{
    double x = x1-x2;
    double y = y1-y2;
    double z = z1-z2;
    double distance = Math.Sqrt(x*x+y*y+z*z);
    return distance;
    
}

try
{
    Console.WriteLine ("Введите координаты первой точки");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine()); 
    int z1 = Convert.ToInt32(Console.ReadLine()); 
      
    Console.WriteLine ("Введите координаты второй точки");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());      

    double rez = Distance(x1, x2, y1, y2, z1, z2);
    Console.WriteLine(rez);
}

catch
{
    Console.WriteLine ("Нужно было вводить целые числа");
}
