---
title: MTA Dev - Lab 2
---

# Lesson 2 Lab:

## Pre-requisites

- [Visual Studio Code](https://aka.ms/win32-x64-user-stable)

- [Dotnet 5.0](https://download.visualstudio.microsoft.com/download/pr/fc1e9923-c4ea-41eb-bddb-165b684fdd4d/cdc2508795eef111e2feb35625e2e460/dotnet-sdk-5.0.100-rc.1.20452.10-win-x64.exe)

## Exercise 1: Examine an object
1. Open Lesson2/Exercise1
1. Open Rectangle.cs
> Take a moment to look at this class that has been defined remember the class is a blueprint for our objects.
3. Press <kbd>F5</kbd> to run the program
> Look at the output you can see the area calculation is not working.
3. Replace `Line 14` with the following:
    ``` csharp
    return this.length * this.width;
    ```
3. Press <kbd>F5</kbd> to run the program 

## Exercise 2: Add a method
1. Open Lesson2/Exercise2
1. Open Program.cs
> Note all the calls that are happening in this code.
> This is almost identical to the example from exercise one. 
3. Open Rectangle.cs
3. Below `//Empty Constructor` add the following:
    ``` csharp
    public Rectangle()
    {
    }
    ```
3. Below `//Init Method` add the following:
    ``` csharp
    public void InitFields(double l, double w)
    {
        this.length = l;
        this.width = w;
    }
    ```

3. Press <kbd>F5</kbd> to run the program


## Exercise 3: Inheritance
1. Open Lesson2/Exercise3
1. Open Program.cs
    > Take a moment to look at this class that has been defined remember the class is a blueprint for our objects.
1. Press <kbd>F5</kbd> to run the program
1. Delete the following (`Line 11` & `Line 12`):
    ``` csharp
    public double Length { get; set; }
    public double Width { get; set; }
    ```

1. Below `//Add Polygon` add the following:
    ``` csharp
    class Polygon
    {
        public double Length { get; set; }
        public double Width { get; set; }
    }
    ```
1. Replace `Line 9` with the following:
    ``` csharp
    class Rectangle : Polygon
    ```
1. Press <kbd>F5</kbd> to run the program
    > **n.b.** the output should be identical to what was output orginally.

## Exercise 4 : Polymorphism
1. Open Lesson2/Exercise3
1. Open Program.cs
    > Take a moment to look at this class that has been defined remember the class is a blueprint for our objects.
1. Press <kbd>F5</kbd> to run the program
1. Add a triangle class at the end of the file:
    ``` csharp
    class Triangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing: Triangle");
        }
    }
    ```
1. Add a triangle into our list at `Line 6`:
    ``` csharp
    polygons.Add(new Triangle());
    ```
1. Press <kbd>F5</kbd> to run the program

1. Add a star class at the end of the file:
    ``` csharp
    class Triangle : Triangle
    {
        public new void Draw()
        {
            Console.WriteLine("Imagining: Star");
        }
    }
    ```
    > Note that the method is now marked `new` rather than `override`
1. Add a start into our list at `Line 7`:
    ``` csharp
    polygons.Add(new Star());
    ```
1. Press <kbd>F5</kbd> to run the program
    > While we expected to see `Imaginging: Start` we instead see `Drawing: Triangle` This is because the Polygon has no knowledge of the change that has been made in Star, the `new` keyword hide anything that may have been belwo it in the inheritance chain.