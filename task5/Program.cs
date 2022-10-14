// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом

Console.Clear();

Console.Write("Введите число ");
string text = Convert.ToString(Console.ReadLine());

int length = text.Length;
for (int i = 0; i<length-1; i++)
{
if (text[i]==text[length-i]) Console.WriteLine("палиндром");
else Console.WriteLine("Не палиндром");
}

 Console.WriteLine("Введите целое число");


