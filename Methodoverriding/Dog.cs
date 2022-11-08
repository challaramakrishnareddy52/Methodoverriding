using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverriding
{
    class Dog : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("The dog says : bow bow");
        }
        class program
        {
            static void Main(string[] args)
            {
                Animal myAnimal = new Animal();
                Pig myPig = new Pig();
                Dog myDog = new Dog();
                myAnimal.animalsound();
                myPig.animalsound();
                myDog.animalsound();
            }
        }
    }
}
