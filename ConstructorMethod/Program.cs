using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod
{
     class Program
    {

        class Human
        {
            string name;
            int age;
            public Human()
            {
                Console.WriteLine("new object create ");

            }
            public Human(string name)
            {
                this.name = name;
            }
            public Human(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void information()
            {
                Console.WriteLine("name {0} age {1} ", name, age);
            }
        }
        static void Main(string[] args)
        {
            Human human = new Human();
            Human human1 = new Human("Emre Çınar");
            Human human2 = new Human("Emre " , 23);
            human1.information();
            human2.information();
        }
    }
}
