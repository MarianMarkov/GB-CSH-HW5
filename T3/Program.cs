// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на чётных позициях.

Console.WriteLine("Размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] Mass = new int[size];
CreateArray(Mass);

void CreateArray(int[] Mass)
{
    int Mx = 1;
    int Mn = 100;
    Console.Write("[ ");
    for(int i = 0; i < Mass.Length; i++)
    {
        Mass[i] = new Random().Next(1,100);
        Console.Write(Mass[i] + " ");
        if (Mass[i] > Mx)
        {
           Mx = Mass[i];
        }
         if (Mass[i] < Mn)
        {
           Mn = Mass[i];
        }
    }
    Console.Write("]");
    Console.WriteLine($" ->  {Mx - Mn} ");
}

