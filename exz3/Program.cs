// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Массив");

int[] massive = CreateArray();
PrintArray(massive);


int[] CreateArray()

{
    int[] res = new int[8];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(0, 9);
    }
    return res;

}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}