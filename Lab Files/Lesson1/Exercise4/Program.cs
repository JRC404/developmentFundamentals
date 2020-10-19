using System;
using System.IO;

StreamReader sr = null;

// Add Try

sr = File.OpenText(@"c:\data.txt");
Console.WriteLine(sr.ReadToEnd());
// Handle Specific Error

// Handle Error

// Close Connection

Console.ReadKey();