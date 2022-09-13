using Internal;
using System.Collections.Generic;

IDictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "One"); //adding a key/value using the Add() method


//The following throws run-time exception: key already added.
//numberNames.Add(3, "Three"); 

foreach (KeyValuePair<int, string> kvp in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

//creating a dictionary using collection-initializer syntax
var cities = new Dictionary<string, string>(){
    {"UK", "London, Manchester, Birmingham"},
    
};

foreach (var kvp in cities)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

//Access
cities["UK"];   //nameDictionary [ nameKey]

//Cheak if exist key
cities.ContainsKey("key");
cities.ContainsKey("value");

//Ubdate
cities["UK"] = "Liverpool", "Brinstol";

//Remove
cities.Remove("UK");
cities.Clear();