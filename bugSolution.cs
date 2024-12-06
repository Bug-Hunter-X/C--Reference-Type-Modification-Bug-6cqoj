public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    //Added a copy constructor
    public MyClass(MyClass other) : this(other.MyProperty) { }

    public static void Main(string[] args)
    {
        MyClass instance1 = new MyClass(10);
        //Create a copy instead of assigning by reference
        MyClass instance2 = new MyClass(instance1);

        instance2.MyProperty = 20;

        Console.WriteLine(instance1.MyProperty); // Output: 10
        Console.WriteLine(instance2.MyProperty); // Output: 20
    }
}