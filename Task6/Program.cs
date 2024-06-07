Vec2 a = new Vec2(1, 2);
Vec2 b = new Vec2(2, 3);

Console.WriteLine($"left.x = {a.X} left.y = {a.Y} right.x = {b.X} right.y = {b.Y}");
Vec2 c = a + b;
Console.WriteLine($"reuslt.x = {c.X} result.y = {c.Y}");

class Vec2
{
    public int X { get; set; }
    public int Y { get; set; }

    //Конструктор для удобства
    public Vec2(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Операторы статичны
    public static Vec2 operator +(Vec2 left, Vec2 right)
    {
        return new Vec2(left.X + left.Y, right.X + right.Y);
    }
}