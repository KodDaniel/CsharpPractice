﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Overloading_Virtual
{
    class Teacher : Person
    {

        public Teacher(string firstName,string lastName) :base (firstName,lastName)
        {

        }
        // Overridar metod från superklass "Person"
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + ". Roll: Lärare.");
            Console.ReadLine();
        }

    }
}
