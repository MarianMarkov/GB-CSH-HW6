float b1, b2, k1, k2, x, y;
Console.Write("Введите b1: ");
b1 = float.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
k1 = float.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
b2 = float.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
k2 = float.Parse(Console.ReadLine()!);

if (k1 == k2)
{
    Console.WriteLine("Прямые коллинеарны");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения [{x};{y}]");
}