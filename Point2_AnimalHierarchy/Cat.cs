﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Cat : Feline , IPet
    {
        string name;
        public Cat(string food, string size, string origin, string furColor, string name, string sleepState) : base(food, size, origin, furColor, sleepState)
        {
            this.name = name;
            Tag = "Cat";
        }

        public void Bath()
        {
            Console.WriteLine(Tag + "" + name + " is bath with: \tSoap");
        }

        public void Vaccinate()
        {
            Console.WriteLine("You have inoculate vaccinated " + name);   //taban al revés
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a Cat and I'm feed with: " + Food + "\n");
        }

        public override void DoNoice()
        {
            Console.WriteLine("Cat noices:\tMeow, Meow");
        }

        public override void Show()
        {
            Console.WriteLine("Name:\t\t" + name + "\nStatus:\t\t" + IPet.Status);
            //No quitar el base, esta es la referncia al metodo Show de la Clase Felino
            base.Show();
        }
    }
}
