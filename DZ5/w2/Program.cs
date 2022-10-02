Console.WriteLine ("Введите количество элементов массива");
int el = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int [] array = new int [el];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 100);
    Console.WriteLine (array[i]);
}
int summ = 0;
for (int j = 0; j < array.Length; j+=2)
{
    summ = summ + array[j];
}
Console.WriteLine("Сумма нечётных элементов массива равна " + summ);
