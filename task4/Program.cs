// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.Clear();

double Distance (int [] frstDot, int [] scndDot, int N)
{
    double sumDots = 0;
    for (int i = 0; i<N; i++)
    {
        sumDots = sumDots + (frstDot[i]-scndDot[i])*(frstDot[i]-scndDot[i]);
    }
    return sumDots;
}


try
{
    Console.Write ("Введите размерность пространства. N = ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] frstDot = new int[N];
    int[] scndDot = new int[N];

    Console.WriteLine ("Введите координаты первой точки");
    for (int i=0; i<N; i++)
    { frstDot[i] = Convert.ToInt32(Console.ReadLine());}

    Console.WriteLine ("Введите координаты второй точки");
    for (int i=0; i<N; i++)
    { scndDot[i] = Convert.ToInt32(Console.ReadLine());}

    double rez = Distance (frstDot, scndDot, N);
    Console.WriteLine($"Расстояние между заданными точками = {rez}");
}

catch
{
    Console.WriteLine("Нужно ввести целые числа");
}