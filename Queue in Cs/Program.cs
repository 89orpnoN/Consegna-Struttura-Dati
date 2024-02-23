
var queue = new Queue_in_Cs.Queue<int>(23);

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

queue.Dequeue();
queue.Enqueue(6);

// funziona, testato con il debugger