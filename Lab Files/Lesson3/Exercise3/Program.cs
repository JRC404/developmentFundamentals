using System;
using System.Collections.Generic;
using System.Linq;

Stack<string> stackOfWords = new Stack<string>();
stackOfWords.Push("stacks");
stackOfWords.Push("can");
stackOfWords.Push("be");
stackOfWords.Push("confusing");
int length = stackOfWords.Count;

string whichWord = stackOfWords.Pop();
length = stackOfWords.Count;

Console.ReadKey();


// Tasks
// 1. after popping, how many words are in the stack?
// 2. what does the method TryPop() allow you to do?
// 3. and the method ToArray()?