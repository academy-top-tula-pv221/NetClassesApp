using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NetClassesApp
{
    struct PersonStruct
    {
        public string name;
        public int age;
        public Address address;
        public PersonStruct(string name, int age, Address address) 
        { 
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Write()
        {
            Console.WriteLine($"{name}  {age}");
        }
    }

    class Address
    {
        public string city;
        public string street;

        public void Write()
        {
            Console.WriteLine($"{city}  {street}");
        }
    }

    class Person
    {
        public string name = "Anonim";
        public int age = 2;
        public void Write()
        {
            Console.WriteLine($"{name}  {age}");
        }

        public void Deconstruct(out string name, out int age)
        {
            name = this.name;
            age = this.age;
        }
    }
}
