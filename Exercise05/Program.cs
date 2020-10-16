using System;

namespace BasicExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                         "Ebenezer", "Francine", "George" };
                decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80,
                                 16.75m };

                Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
                for (int ctr = 0; ctr < names.Length; ctr++)
                    Console.WriteLine("{0,-20} {1,1} {2,5:N2}", names[ctr], "$" , hours[ctr]);
                /* 
                 * first number denotes which item in the list to format
                 * second number denotes 1: how wide the space is and 2: where to justify
                 * negative causes left justify
                 * no negative causes right justify
                 * N2 shows how many decimals to show
                 * 
                 * 
                 */
            }
        }
    }
}
