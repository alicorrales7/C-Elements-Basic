using Internal;
using System.Collections.Generic;

Queue<int> callerIds = new Queue<int>();
callerIds.Enqueue(1);
callerIds.Enqueue(2);
callerIds.Enqueue(3);
callerIds.Enqueue(4);

foreach (var id in callerIds)
    Console.Write(id); //prints 1234

//Count => Retuns the total of elements
//Enqueue(T) => add an item into the queue
//Dequeue => Retuns an item from the beginning and removes it from the queue
//Peek() => Returns an first element from the queue
//Contains(T) => Checks whether an item is in the queue or not
//Clear() => Removes all items from the queue