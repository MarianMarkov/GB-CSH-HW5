// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

void PrintArray(int[] Mass)
{
    Console.Write("[ ");
    for(int i = 0; i < Mass.Length; i++)
    {
        Console.Write(Mass[i] + " ");
    }
    Console.Write("]");
}

void CreateArray(int[] Mass)
{
    for(int i = 0; i < Mass.Length; i++)
    {
        Mass[i] = new Random().Next(1,10);
    }
    
}

void GetProdMass(int[] ProdMass, int[] Mass)
{
    for (int i = 0; i < Mass.Length / 2; i++)
    {
        ProdMass[i] = Mass[i] * Mass[Mass.Length - i - 1];
    }
    if (Mass.Length % 2 != 0)
    {
        ProdMass[ProdMass.Length - 1] = Mass[Mass.Length / 2];
    }
}

Console.WriteLine("Размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] Mass = new int[size];
int PMsize;
if (size % 2 == 0)
{
    PMsize = size / 2 ;
}
else
{
    PMsize = size / 2 + 1;
}
int[] ProdMass = new int[PMsize];
CreateArray(Mass);
GetProdMass(ProdMass, Mass);
PrintArray(Mass);
Console.Write($" ->  ");
PrintArray(ProdMass);


