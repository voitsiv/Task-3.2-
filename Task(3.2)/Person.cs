using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2_
{
    internal class Person 
    {
        private string nameAuthor;
        private int ageAuthor;

        public Person(string nameAuthor, int ageAuthor)
        {
            this.nameAuthor = nameAuthor;
            this.ageAuthor = ageAuthor;
        }
        public override string? ToString()
        {
            return "\nnameAuthor: " + nameAuthor
                + "\n" + "ageAuthor: " + ageAuthor;
        }

        public string NameAuthor { get => nameAuthor; set => nameAuthor = value; }
        public int AgeAuthor { get => ageAuthor; set => ageAuthor = value; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Person objPerson = obj as Person;
            if (nameAuthor == objPerson.nameAuthor
                && ageAuthor == objPerson.ageAuthor) 
                return true;
            else
                return false;
        }

        public static bool operator ==(Person obj1, Person obj2)
        {
            //if (obj1 == null || obj2 == null)
            //    return false;
            //Person objPerson1 = obj1 as Person;
            //Person objPerson2 = obj2 as Person;
            //if (objPerson2.nameAuthor == objPerson1.nameAuthor
            //    && objPerson2.ageAuthor == objPerson1.ageAuthor)
            //    return true;
            //else
            //    return false;
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Person obj1, Person obj2)
        {
            //if (obj1 == null || obj2 == null)
            //    return true;
            //Person objPerson1 = obj1 as Person;
            //Person objPerson2 = obj2 as Person;
            //if (objPerson2.nameAuthor == objPerson1.nameAuthor
            //    && objPerson2.ageAuthor == objPerson1.ageAuthor)
            //    return false;
            //else
            //    return true;
            return !(obj1 == obj2);
        }

        public override int GetHashCode()
        {
            return nameAuthor.GetHashCode() ^ ageAuthor.GetHashCode();
        }

        public virtual object DeepCopy()
        {
            return new Person(nameAuthor, ageAuthor);
        }




    }
}

