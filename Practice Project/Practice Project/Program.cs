using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string person1Name = "Mike";
           
            int person1Age;
            person1Age = 25;
            bool oldAge = person1Age > 50;
            bool male = true;
            string gender;
            string herHim;

            if (male == false)
            {
                gender = "she";
                herHim = "her";
            }
            else
                gender = "he";

            if (oldAge == true)
                Console.WriteLine("Although " + person1Name + " was an elderly citizen" +
                    " at the ripe age of " + person1Age + ", " + "they still knew their way around " +
                    "the block.");
            else
                Console.WriteLine("Although " + person1Name + " was a young buck, " + gender +
                    " had an old soul.");


            


          

            




            





            
        }
    }
}
