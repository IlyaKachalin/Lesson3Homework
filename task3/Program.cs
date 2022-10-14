// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();

string Square (int x)
{
    string result = "0";
    for (int i = 1; i<=x; i++)

    { result = result + ", " + Convert.ToString(i*i*i);}
    return result;
}

try
{
    Console.Write ("Введите число N. N = ");
    int x = Convert.ToInt32 (Console.ReadLine());

    if (x<0) Console.WriteLine("Введите натуральное значение N");
    else
    {
        string rez = Square(x);
        Console.WriteLine (rez);
    }
}

catch
{
    Console.WriteLine("Введите целые чила");
}


