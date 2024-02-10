// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var stack = new Steck<int>(34);

stack.Push(43);
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

stack.Pop();
stack.Push(5);  