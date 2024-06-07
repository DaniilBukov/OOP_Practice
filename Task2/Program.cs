
using System.Reflection;

// Получаем тип
Type myType = typeof(MyClass);

// Получаем метод - обязательно ставим BindingFlags
var myMethod = myType.GetMethod("PrintString", BindingFlags.Static | BindingFlags.NonPublic);

//Поверяем, есть ли такой метод
if (myMethod != null)
{
    // Выводим название метода
    Console.WriteLine($"{myMethod.Name}");

    // Вызываем метод, 1 параметр - ссылка на объект (его нет, так как метод статический), второй параметр - массив объектов-аргументов(все классы наследуются от object)
    myMethod.Invoke(null, new object[] { "123" });
}
class MyClass
{
    private static void PrintString(string str) => Console.WriteLine(str);
}