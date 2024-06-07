




Type myType = typeof(MyClass);

foreach (var method in myType.GetMethods())
{
    Console.WriteLine(method.Name);
}

class MyClass
{
    private static void PrintString(string str) => Console.WriteLine(str);

}