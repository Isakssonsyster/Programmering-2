using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your Name?");
            String name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nHow old are you?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nAre you alive?");
            Boolean alive = Convert.ToString(Console.ReadLine());
            Boolean dead = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nWhat is your Name?\n" + name);
            Console.WriteLine("\nHow old are you?\n" + age);

            if (alive = true)
            {
                Console.WriteLine("\nAre you alive?\n" + alive);
            }
           
            else if(alive = false)
            {
                Console.WriteLine("\nAre you alive?\n" + dead);
            }
            


            
        }
    }
}
