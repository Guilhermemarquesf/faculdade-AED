# C# Recursive Printer

A lightweight C# console application developed to practice and demonstrate fundamental programming concepts, specifically **recursion** and localized static methods.

## 🎯 About The Project

This project takes a user-defined integer input and utilizes a recursive function to print a sequence line by line until the target count is reached. It serves as a practical exercise for understanding control flow, call stacks, and parameter passing in C#.

## 🚀 Key Features

* **User Input Handling:** Safely captures and parses numeric input from the console.
* **Recursive Algorithm:** Implements a custom static method (`Imprime`) that invokes itself iteratively as an alternative to traditional `for` or `while` loops.
* **Modern Syntax:** Utilizes C# string interpolation (`$""`) for clean and readable output formatting.

## 💻 Code Highlight

The core logic relies on the following recursive method:

```csharp
static void Imprime(string Texto, int Nr, int QtdeVezes)
{
    if (Nr <= QtdeVezes)
    {
        Console.WriteLine($"{Texto} {Nr}");
        Nr++;
        Imprime(Texto, Nr, QtdeVezes); // Recursive call
    }
}