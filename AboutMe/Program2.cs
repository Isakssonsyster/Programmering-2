using System;
using System.Linq.Expressions;

namespace Lektion_vecka_36
{
    class Program
    {
        

        static void Main(string[] args)
        {

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("What is your Name?");
                String name = Convert.ToString(Console.ReadLine());

                while (name == " ")
                {
                    Console.WriteLine("What is your Name?");
                    name = Convert.ToString(Console.ReadLine());
                }

                Console.WriteLine("\nHow old are you?");
                int age = Convert.ToInt16(Console.ReadLine());

                switch (age)
                {

                    case 15:
                        Console.WriteLine("You are allowed to drive a moped now!");
                        break;

                    case 16:
                        Console.WriteLine("You can now drive light MC");
                        break;

                    case 17:
                        Console.WriteLine("Yay you can not do anything special in this age really...");
                        break;

                    case 18:
                        Console.WriteLine("You are now legally a grownup!");
                        break;



                }


                Console.WriteLine("\nAre you alive?");
                String alive = Convert.ToString(Console.ReadLine());



                Console.WriteLine("\nWhat is your Name?\n" + name);
                Console.WriteLine("\nHow old are you?\n" + age);



                if (alive == "yes")
                {

                    Console.WriteLine("\nAre you alive?\n" + alive);

                }

                else if (alive != "yes")
                {

                    Console.WriteLine("\nAre you alive?\n" + "I think you are dead");
                }

            }
      

        }




        }
    }