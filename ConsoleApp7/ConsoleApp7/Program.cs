// See https://aka.ms/new-console-template for more information
using System;
using ConsoleApp7;





var list = new SingleLinkedList<string>();
MyQueue<string> queue = new MyQueue<string>();
StackT<string> stack= new StackT<string>();

//list.AddToEnd("Jane");
//list.AddToEnd("Gozie");
//list.AddToEnd("Udoka");
////Console.WriteLine(list.Check("Jane"));
//Console.WriteLine(list.IndexPos("Jane"));
//Console.WriteLine(list.IndexPos("Jane"));



//Console.WriteLine(queue.EnQueue("Hello World"));
queue.EnQueue("Hello");
queue.EnQueue("J");
queue.Dequeue();
Console.WriteLine(queue.Count());


//Console.WriteLine(queue.IsEmptyQ());


