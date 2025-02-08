public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize property

    public void MyMethod()
    {
        // Now the property has a default value of 0 
        int value = MyProperty; // Accessing the property
        Console.WriteLine(value); // output will be 0 
        MyProperty = 10; // Assign a value
        value = MyProperty; // Accessing the property
        Console.WriteLine(value); // output will be 10 
    }
}