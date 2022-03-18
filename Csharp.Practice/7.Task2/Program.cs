object[] objects = new object[3];
objects[0] = 32;
objects[1] = 'A';
objects[2] = "Hello";
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(objects[i]);
}

objects[0] = (int)objects[0]+10;
objects[2] = objects[2]+", guys!";
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(objects[i]);
}

Console.ReadKey();