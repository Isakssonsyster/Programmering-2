﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace OOPlabb
{
    class Program
    {

        static void Main(string[] args)
        {
            ClientName client = new ClientName();
            client.name = Console.ReadLine();

            Products product1 = new Products();
            Products product2 = new Products();
            Products product3 = new Products();


            product1.BMW = "\n1. BMW";
            product2.Tesla = "\n2. Tesla";
            product3.Volvo = "\n3. Volvo";



            Console.WriteLine("Hello " + client.name);

            while (true)
            {
                int ClientWantsProduct = Convert.ToInt32(Console.ReadLine());

                switch (ClientWantsProduct)
                {

                    case 1:
                        Console.WriteLine("You want a" + product1.BMW);

                        continue;

                    case 2:

                        Console.WriteLine("You want a" + product2.Tesla);

                        continue;

                    case 3:

                        Console.WriteLine("You want a" + product3.Volvo);

                        continue;
                }
                break;
            }
          
           
            
        }

    }
}
