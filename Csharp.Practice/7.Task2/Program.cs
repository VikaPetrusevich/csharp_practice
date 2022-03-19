// Создание одномерного массива из трех элементов
Console.WriteLine("Create a one-dimensional array.");
object[] objects = new object[3];
objects[0] = 32;
objects[1] = 'A';
objects[2] = "Hello";
for (int i = 0; i < objects.Length; i++)
{
    Console.WriteLine(objects[i]);
}

Console.WriteLine("Change array.");

objects[0] = (int)objects[0]+10;
objects[2] = (string)objects[2]+", guys!";

for (int i = 0; i < objects.Length; i++)
{
    Console.WriteLine(objects[i]);
}

Console.ReadKey();