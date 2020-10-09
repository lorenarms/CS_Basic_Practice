using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercise06.People
{
    public class Person
    {
        public string Name;
        public int Age;
        public char Sex;
        public bool HasPet;


        public string Greeting()
        {
            if (HasPet == true)
                return "How is your pet?";
            else
                return "How are you?";
        }

    }
}
