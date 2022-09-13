using System;

namespace Test {

    public class Human
    {
        
        private string name;
        private string addres;
        private int age;
        private string fullname;


        public Human(string name, string addres, int age)
        {
            this.name = name;
            this.addres = addres;
            this.age = age;

        }

        public Human(string name, string apellido) {
            this.fullname = name + " "+ apellido;
        }

        public void ToWork() {
            Console.WriteLine("Hola {1}, {2}",name,addres,age);
        }

        public string FullName()
        {
            return fullname;
        }

        public int Age()
        {
            return age;
        }

    
    }
    
}
