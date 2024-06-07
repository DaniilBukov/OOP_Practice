MyBaseClass myChildClass = new MyChildClass();

myChildClass.MyVirtual();
myChildClass.MyAbstract();


//Чтобы создать абстрактный метод, класс должен быть абстрактным!!!
abstract class MyBaseClass
{
    public virtual void MyVirtual() { }
    public abstract void MyAbstract();

    public MyBaseClass() { }
}

class MyChildClass : MyBaseClass
{
    //sealed - запрет переопределения (если спросят)
    public override sealed void MyVirtual()
    {
        Console.WriteLine("Child virtual");
    }
    public override void MyAbstract()
    {
        Console.WriteLine("Child abstract");
    }

    public MyChildClass() : base() { }
}