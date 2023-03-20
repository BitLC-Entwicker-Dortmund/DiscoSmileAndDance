using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoSmileAndDance {
    internal class Disco {
        private List<PersonenHuelle> huelleList=new List<PersonenHuelle>();

        public void NimmAuf(Person p) {
            PersonenHuelle ph = new PersonenHuelle();
            ph.SetPerson(p);
            huelleList.Add(ph);
        }

        public Person GehRaus() {
            Person p = null;
            p = huelleList[0].GetPerson();
            // löschen
            return p;
        }

    }
}
