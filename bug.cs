public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned can lead to unexpected behavior.
        int value = MyProperty; // Uninitialized property will have default value 0
        Console.WriteLine(value); 
    }
}