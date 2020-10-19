using System;
using System.IO;

var a = 1;
int b = 2;
Console.WriteLine($"B is:{b}");
string name = "Joe";

// Add a to b
int c = 1+2;//
Console.WriteLine($"C is:{c}");

// Divide c by b
var d = c/b;
Console.WriteLine($"D = c/b");
Console.WriteLine($"D is:{d}");
Console.WriteLine($"D is a {d.GetType().Name}");

// Operator Code


var f = d;

Console.WriteLine($"D is {d}");
Console.WriteLine($"F is {f}");


Console.ReadKey();