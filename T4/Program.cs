// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] Mass = new int[size];
CreateArray(Mass);

void CreateArray(int[] Mass)
{
    Console.Write("[ ");
    for(int i = 0; i < Mass.Length; i++)
    {
        Mass[i] = new Random().Next(1,10);
        Console.Write(Mass[i] + " ");
    }
    Console.Write("]");
    Console.Write($" ->  ");
    for (int i = 0; i < Mass.Length / 2; i++)
    {
        Console.Write(" ");
        Console.Write(Mass[i] * Mass[Mass.Length - i - 1]);
        Console.Write(" ");
    }
    if (Mass.Length % 2 != 0)
    {
        Console.Write(Mass[Mass.Length/2]);
    }
    
}

