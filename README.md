# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been initialized. This can lead to unexpected behavior or runtime exceptions.

The `bug.cs` file shows the problematic code, where the `MyProperty` is accessed before a value is assigned to it. The `bugSolution.cs` file shows how to fix this issue.

## How to Reproduce

1. Clone this repository.
2. Compile and run the `bug.cs` file. You'll see a runtime exception because `MyProperty` is accessed before a value has been assigned.
3. Compile and run the `bugSolution.cs` file to see the correct implementation.

## Solution

The solution involves ensuring the property is assigned a value before it is accessed. This is commonly done in one of the following ways:

- **Assigning a default value in the declaration**: By initializing the property directly.
- **Assigning a value in the constructor**: This ensures that every instance has the property initialized.
- **Using null conditional operator (?.)**: To safely access the property if it's null, preventing exceptions.

This example highlights the importance of property initialization in C# to avoid unexpected behavior and runtime errors.