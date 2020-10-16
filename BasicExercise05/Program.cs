using System;

namespace BasicExercise05
{

    /*
             creating classes and objects
            6: How To Create Classes And Objects In C# | C# Tutorial For Beginners | C Sharp Tutorial
            Dani Krossing video
            */





    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Lawrence";
            person.Age = 37;
            person.HasPet = true;

            Person person2 = new Person();
            person2.Name = "Angelina";
            person2.Age = 42;
            person2.HasPet = true;

            person.Greeting();
            person2.Years();

        }

    }
    
    public class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hello " + Name);
            

        }
        public void Years()
        {
            Console.WriteLine(Name + " is " + Age + " years old.");
        }
    }


}
