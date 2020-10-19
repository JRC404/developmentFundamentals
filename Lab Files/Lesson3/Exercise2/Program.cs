using System;
using System.Collections.Generic;
using System.Linq;


Queue<string> queueOfWords = new Queue<string>();
queueOfWords.Enqueue("queues");
queueOfWords.Enqueue("are");
queueOfWords.Enqueue("more");
queueOfWords.Enqueue("flexible");
int length = queueOfWords.Count;

string whichWord = queueOfWords.Dequeue();
length = queueOfWords.Count;

Console.ReadKey();

// Tasks
// 1. after dequeuing, how many words are in the queue?
// 2. what does the method Peek allow you to do?
// 3. and the method Contains?

Console.ReadKey();