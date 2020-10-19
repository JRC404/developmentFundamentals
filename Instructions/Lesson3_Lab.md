---
title: MTA Dev - Lab 3
---

# Lesson 3 Lab:

## Pre-requisites

- [Visual Studio Code](https://aka.ms/win32-x64-user-stable)

- [Dotnet 5.0](https://download.visualstudio.microsoft.com/download/pr/fc1e9923-c4ea-41eb-bddb-165b684fdd4d/cdc2508795eef111e2feb35625e2e460/dotnet-sdk-5.0.100-rc.1.20452.10-win-x64.exe)

## Exercise 1: Arrays
1. Open Lesson3/Exercise1
1. Open Program.cs
> Instead of listing each change to start with please attempt the following step and come back here if required for detailed instructions:
    >   1. change "type" to "kind"
    >   2. print out the last word in the array
    >   3. add any word to the end of the array
> 
> The rest of this file list how to acheive the above.
3. Change `type` to `kind` using code (Line 10)
    ``` csharp
    arrayOfWords[3] = "kind";
    ```
3. Print out the last word in the array (Line 13)
    ``` csharp
    Console.WriteLine(arrayOfWords[length-1]);
    ```
3. add any word to the end of the array (Line 18)
    ``` csharp
    var list = arrayOfWords.ToList<string>();
    list.Add("bla");
    arrayOfWords = list.ToArray();
    ```
## Exercise 2: Queues
1. Open Lesson3/Exercise2
1. Open Program.cs
1. Look at the code and answer the following questions
    - after dequeuing, how many words are in the queue?
    - what does the method Peek allow you to do?
    - what does method Contains allow you to do?
1. Press <kbd>F5</kbd> to run the program
    > Check your answers
## Exercise 3: Stacks
1. Open Lesson3/Exercise3
1. Open Program.cs
1. Look at the code and answer the following questions
    - after popping, how many words are in the stack?
    - what does the method TryPop() allow you to do?
    - what does the method ToArray() do?
1. Press <kbd>F5</kbd> to run the program
    > Check your answers