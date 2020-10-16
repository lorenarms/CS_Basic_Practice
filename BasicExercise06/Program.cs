using System;
using BasicExercise06.People;

namespace BasicExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person01 = new Person();
            Person person02 = new Person();

            person01.Name = "Lawrence";
            person01.Age = 37;
            person01.Sex = 'M';
            person01.HasPet = true;

            person02.Name = "Angelina";
            person02.Age = 42;
            person02.Sex = 'F';
            person02.HasPet = false;

            string[] greeting = { " ", " " };
                
            greeting[0] = person01.Greeting();
            greeting[1] = person02.Greeting();

            for(int i = 0; i < greeting.Length; i++)
            {
                Console.WriteLine(greeting[i]);
            }






        }
    }
}
