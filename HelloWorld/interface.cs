using System;
namespace HelloWorld
{
    public interface Human
    {
        string Fullname();
        int GetSum(int number);
    }
//An interface can contain declarations of methods, properties, indexers, and events


//Class can implemet the interface of this way,
//Class must be implement all element that exist in the interface
class Profesor: Human
    {
        public string Fullname()
        {
            return "Hola";
        }

        public int GetSum(int number) {
            return number;
        }
    }
}
