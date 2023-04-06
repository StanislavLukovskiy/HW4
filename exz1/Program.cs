// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = ReadInt("Введите первое число ");
int number2 = ReadInt("Введите второе число ");
for(int i = number1; i <= number1; i++)
{
System.Console.Write(Math.Pow(i,number2) + " ");
}