using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2_
{
    internal class Article : InterfaceRateAndCopy
    {
        private Person person;
        private string name;
        private double rate;

        public Article(Person person, string name, double rate)
        {
            this.person = person;
            this.name = name;
            this.rate = rate;
        }
        public Article()
        {
            this.person = new Person("John", 34);
            this.name = "Andriy";
            this.rate = 5.4d;
        }

        public string Name { get => name; set => name = value; }
        public double Rate { get => rate; set => rate = value; }
        internal Person Person { get => person; set => person = value; }

        public double Rating { 
            get 
            { 
                return this.rate; 
            } 
        }

        public override string? ToString()
        {
            return name + " " + rate + " " + person;
        }

        public object DeepCopy()
        {
            return new Article(Person, Name, Rate);
        }
    }
}
