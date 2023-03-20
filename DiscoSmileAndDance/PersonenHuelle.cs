using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoSmileAndDance {
    internal class PersonenHuelle {
        private Person person;
        public void Tanzen() {
            Console.WriteLine(  "Objekt tanzt");
        }
        public void Laecheln() {
            Console.WriteLine("Objekt lächelt");
        }
        public void SetPerson(Person p) {
            person = p;
        }
        public Person GetPerson() {
            return person;
        }
    }
}
