# Uninitialized Property Access in C#

This code demonstrates a common but subtle error in C#: accessing a property before it's been assigned a value.  In this example, `MyProperty` is an integer property that is accessed in the `MyMethod` function before it's explicitly assigned a value. This results in the default value of the integer type (0) being used.   Uninitialized properties can often lead to unexpected behavior and hard-to-find bugs, especially in larger and more complex projects.  A solution involving explicitly initializing the property is shown in the 'bugSolution.cs' file.

**How to reproduce:**

1. Compile and run `bug.cs`
2. Observe the output - it will print 0.
3. Examine `bugSolution.cs` to see how to fix it.