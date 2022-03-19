// Одномерный целочисленный массив длиной 13
Console.WriteLine("Create array.");

int[] numbers = new int[13];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1,100);
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("\nMaximum value of the array.");

Console.WriteLine(numbers.Max());

Console.ReadKey();
