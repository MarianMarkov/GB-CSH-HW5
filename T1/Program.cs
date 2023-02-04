// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] Mass = new int[size];
CreateArray(Mass);

void CreateArray(int[] Mass)
{
    int EvenCount = 0;
    Console.Write("[ ");
    for(int i = 0; i < Mass.Length; i++)
    {
        Mass[i] = new Random().Next(100,1000);
        Console.Write(Mass[i] + " ");
        if (Mass[i] % 2 == 0)
        {
            EvenCount++;
        }
    }
    Console.Write("]");
    Console.WriteLine($" ->  {EvenCount} ");
}

