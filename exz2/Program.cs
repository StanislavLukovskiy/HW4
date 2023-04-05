// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadInt(string message);
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
