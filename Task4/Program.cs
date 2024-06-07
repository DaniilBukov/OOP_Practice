//Ввод
int arrSize = 0;
try
{
    arrSize = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
//объект рандома
Random random = new Random();
//собсна сами значения
MyChildClass[] myChildClasses1 = new MyChildClass[arrSize];
MyChildClass[] myChildClasses2 = new MyChildClass[arrSize];
//заполнение
for (int i = 0; i < arrSize; i++)
{
    myChildClasses1[i] = new MyChildClass(GenerateRandomStr(16), GenerateRandomBool());

    myChildClasses2[i] = new MyChildClass(GenerateRandomStr(16), GenerateRandomBool());
    Console.WriteLine($"myChildClasses1: bool = {myChildClasses1[i].MyBool} myChildClasses2: bool = {myChildClasses2[i].MyBool}");
}
//проверка
int fCount1 = 0;
int fCount2 = 0;
for (int i = 0; i < arrSize; i++)
{
    if (myChildClasses1[i].MyBool == false) fCount1++;
    if (myChildClasses2[i].MyBool == false) fCount2++;
}

if (fCount1 > fCount2) Console.WriteLine("myChildClasses1");
else if (fCount1 == fCount2) Console.WriteLine("myChildClasses1 == myChildClasses2");
else Console.WriteLine("myChildClasses2");

string GenerateRandomStr(int maxSize)
{
    string str = "";
    for (int i = 0; i <= random.NextInt64(0, maxSize); i++)
    {
        str += Convert.ToChar(random.Next(65, 122));
    }
    return str;
}

bool GenerateRandomBool()
{
    if (random.Next(0, 2) == 0) return false;
    else return true;
}
//как в первой
class MyBaseClass
{
    public string MyStr { get; set; }
    public bool MyBool { get; set; }

    public MyBaseClass(string myStr, bool myBool)
    {
        MyStr = myStr;
        MyBool = myBool;
    }
}

class MyChildClass : MyBaseClass
{
    public MyChildClass(string myStr, bool myBool) : base(myStr, myBool)
    {
    }
}