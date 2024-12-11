public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public ExampleClass() 
    {
        // Or, initialize it within the constructor
        MyProperty = 10;
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; // Accessing the property after initialization
    }
} 