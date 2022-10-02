Console.WriteLine ("Введите количество элементов массива");
int el = Convert.ToInt32(Console.ReadLine());
int [] array = new int [el];
Random rand = new Random();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.WriteLine (array[i]);
    if (array [i] % 2 == 0)
    count++;
}
Console.WriteLine("Чётных чисел в массиве - " + count);