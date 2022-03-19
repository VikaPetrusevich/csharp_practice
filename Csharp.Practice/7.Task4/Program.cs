Console.WriteLine("Boxing and unboxing.");
short valueType = 100;
object referenceType = (object)valueType;

Console.WriteLine(referenceType.GetType());
Console.WriteLine(referenceType);

sbyte valueType2 = (sbyte)(short)referenceType;

Console.WriteLine(valueType2.GetType());
Console.WriteLine(valueType2);

Console.ReadKey();
