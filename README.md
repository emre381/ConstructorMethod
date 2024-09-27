
---

# ConstructorMethod - C# Project Demonstrating Constructors

This project demonstrates the use of **constructors** in C#. The project defines a `Human` class with several constructors to initialize objects with different sets of information.

## Description

In object-oriented programming, constructors are special methods used to initialize objects. This project illustrates how to create and use constructors to initialize `Human` objects with various combinations of parameters (name and age).

### Class: `Human`

#### Fields:
- **name** (string): The name of the person.
- **age** (int): The age of the person.

#### Constructors:
1. **Human()**: This is a parameterless constructor that simply prints a message when a new `Human` object is created.
   
2. **Human(string name)**: This constructor takes a person's name as a parameter and assigns it to the `name` field.

3. **Human(string name, int age)**: This constructor takes both the `name` and `age` parameters and assigns them to their respective fields.

#### Methods:
- **information()**: This method prints the name and age of the `Human` object to the console.

## Main Method:
In the `Main` method, three instances of the `Human` class are created using different constructors, demonstrating how each constructor is used:

1. **human**: Created using the parameterless constructor, which just prints a message.
2. **human1**: Created using the constructor that accepts only the `name` parameter.
3. **human2**: Created using the constructor that accepts both `name` and `age` parameters.

After creating the objects, the `information()` method is called to display the name and age of `human1` and `human2`.

### Code Example:

```csharp
Human human = new Human();                      // Parameterless constructor
Human human1 = new Human("Emre Çınar");          // Constructor with name
Human human2 = new Human("Emre", 23);            // Constructor with name and age

human1.information();  // Output: name Emre Çınar age 0
human2.information();  // Output: name Emre age 23
```

### Output Example:

```
new object create 
name Emre Çınar age 0 
name Emre age 23
```

## Key Concepts:

- **Constructors**: Special methods used to initialize objects. They can be overloaded to allow flexibility in how objects are created.
  
- **Overloading Constructors**: This project demonstrates constructor overloading, where multiple constructors are defined with different parameters.

- **Default Values**: If a field (such as `age`) is not initialized, it will use the default value (in this case, `0` for an `int`).

## How to Run:
1. Clone or download the project to your local machine.
2. Open the project in a C# IDE (like Visual Studio).
3. Run the program by pressing `F5` or clicking "Start" in your IDE.

## Purpose:
This project serves as a demonstration of:
- Creating constructors in C#.
- Overloading constructors to provide multiple ways to initialize an object.
- The importance of constructors in object-oriented programming for setting initial values.

---

