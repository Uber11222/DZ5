Console.WriteLine ("Введите количество элементов массива");
int el = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
double min = 0;
double max = 0;
double [] array = new double [el];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble()*100;
    Console.WriteLine (array[i]);
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array [i];
    }
    else min = array[i];
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("максимальное в массиве - " + max);
Console.WriteLine("минимальное в массиве - " + min);
Console.WriteLine($"разница между максимальным и минимальным элементами - {max - min}");