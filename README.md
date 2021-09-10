# C# Learning

C# (C-Sharp) is an object-oriented programming language developed by Microsoft that runs on the .NET Framework. C# can be used to develop desktop apps, web apps, mobile apps, microservices, games, IoT and much more.

## Start writing C# with Visual Studio Code

In order to learn how to write C#, you can use Visual Studio or Visual Studio Code. In this tutorial, I prefer using Visual Studio Code.

1. Go to [official website](https://dotnet.microsoft.com/download).
2. In .NET 5.0 section, click download .NET SDK x64.
3. When installation is completed, you can check the version via `dotnet --version`
4. Open Visual Studio Code
5. Console Application is the simple C# app that used in this tutorial. Use `dotnet new console` to create console app.
6. Start coding!

## Basic Syntax

When create console app, `Program.cs` will be created as a main file.

```c#
// enable us to use classes from the System namespace
using System;

// a container for classes and other namespace
namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

```

- Use curly braces ({}) marks the beginning and the end of a block of code
- Every statement ends with a semicolon (;)
- case-sensitive
- The name of C# file don't need to match with the class name, but often do the same name.
- Comment with single-line comment (//) and multi-line comment (/\* \*/)
- Use double quote

## Variables & Data Types

Data types: int, long, float, double, char, string, bool

```c#
string name = "Carlos";
Console.WriteLine(name);

name = "John";
```

```c#
// declare multiple variables
int x = 5, y = 10, z = 20;
Console.WriteLine(x + y + z)
```

### constants

const keyword used to prevent overwriting existing value.

```c#
const string name = "Carlos";
name = "John"; // error
```

## Type Casting

1. Implicit casting (automatically) - converting a smaller type to a larger type size `char -> int -> long -> float -> double`
2. Explicit Casting (manually) - converting a larger type to a smaller size type `double -> float -> long -> int -> char`

```c#
// implicit casting
int myInt = 12;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 12
Console.WriteLine(myDouble);   // Outputs 12

// explicit casting
double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9

// Type Conversion Methods
Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToInt64(myDouble));  // convert double to long
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
Console.WriteLine(Convert.ToBoolean(myString));   // convert string to boolean
```

## User Input

```c#
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
```

## Operator

[C# operator document](https://www.w3schools.com/cs/cs_operators.php)

## String

string in C# is an object which contain properties and methods that can be used.

1. str.Length - give the length of the string
2. str.ToUpper() - convert to uppercase
3. str.ToLower() - convert to lowercase
4. string.Concat(str1, str2) - concatenate two strings
5. str.IndexOf("a") - find index position of a specific character in a string
6. str.Contains("hello") - return true if the string has string hello

### String Interpolation

```c#
string firstName = "Chitsanupong";
string lastName = "Tangvasinkul";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);
```

## Condition

```c#
if (x > y) {
    ...
} else if (x < y) {
    ...
} else {
    ...
}
```

### Short hand condition (Ternary Operator)

```c#
// variable = (condition) ? expressionTrue :  expressionFalse;

int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
```

## Switch Case

```c#
int day = 4;
switch (day)
{
  case 6:
    Console.WriteLine("Today is Saturday.");
    break;
  case 7:
    Console.WriteLine("Today is Sunday.");
    break;
  default:
    Console.WriteLine("Looking forward to the Weekend.");
    break;
}
```

## Loop

### While Loop

```c#
// While loop
int i = 0;
while (i < 10)
{
  Console.WriteLine(i);
  i++;
}

// do/while loop
int i = 0;
do
{
    // executed before go inside while loop
  Console.WriteLine(i);
  i++;
}
while (i < 5);
```

### For loop

```c#
for (int i = 0; i < 5; i++)
{
  Console.WriteLine(i);
}

// for each
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars)
{
  Console.WriteLine(i);
}
```

Tip: break and continue can be used in loop.

## Arrays

```c#
// create an array with many ways
// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[0] = "Opel";
Console.WriteLine(cars[0]);

// for each loop
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars)
{
  Console.WriteLine(i);
}

// sort array in an ascending order
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}
```

```c#
// System.Linq namespace has many useful array methods
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    }
  }
}
```

## OOP

class, method, object, constructor, inheritance, polymorphism, interface, and abstraction concept.

```c#
// Car.cs
using System;

namespace MyApplication
{
    // class
    class Car
    {
        // field
        private string color;
        string model;

        // constructor
        public Car(string color, string model)
        {
            this.color = color;
            this.model = model;
        }

        public string Color
        {
            get { return color; }   // get method
            set { color = value; }  // set method
        }

        // method
        public void printColor()
        {
            Console.WriteLine(this.color);
        }

        public void printModel()
        {
            Console.WriteLine(this.model);
        }
    }
}


// Program.cs
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object
            Car car = new Car("blue", "tesla S");
            car.printColor();
            car.printModel();
            Console.WriteLine(car.Color);
        }
    }
}
```

### Access Modifiers

1. public - accessible for all classes
2. private - only accessible within the same classes (default)
3. protected - accessible within the same class or in a class that is inherited from thta class
4. internal - accessible within its own assembly

## Getter and Setter

To prevent changing properties of the object directly, you can use getter and setter.
