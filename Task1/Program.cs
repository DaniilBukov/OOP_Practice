


MyClass myClass = new MyClass(1, "2");



int size = 0;

try
{
    size = Convert.ToInt32((Console.ReadLine()));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

MyClass[] myClasses = new MyClass[size];

Random rand = new Random();



for (int i = 0; i < size; i++)
{
    myClasses[i] = new MyClass(rand.Next(-256, 256), GenerateRandom(16));

}

foreach (MyClass _class in myClasses)
{
    Console.WriteLine($"MyInt: {_class.MyInt}");
    Console.WriteLine($"MyString:{_class.MyString}\n");
}


string GenerateRandom(int _maxSize)
{
    string str = "";
    for (int i = 0; i <= rand.NextInt64(0, _maxSize); i++)
    {
        str += Convert.ToChar(rand.Next(65, 122));
    }
    return str;
}

class MyClass
{
    public int MyInt { get; init; }

    public string MyString { get; init; }

    public MyClass(int myInt, string myString)
    {
        MyInt = myInt;
        MyString = myString;
    }
}

