using System;

var person = (1, "Bill", "Gates");

//equivalent Tuple
//var person = Tuple.Create(1, "Bill", "Gates");



ValueTuple<int, string, string> person = (1, "Bill", "Gates");
person.Item1;  // returns 1
person.Item2;   // returns "Bill"
person.Item3;   // returns "Gates"



(int, string, string) person = (1, "James", "Bond");
person.Item1;  // returns 1
person.Item2;   // returns "James"
person.Item3;   // returns "Bond"
