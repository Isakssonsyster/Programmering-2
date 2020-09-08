using System;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Write five names:");
            String name1 = Convert.ToString(Console.ReadLine());
            String name2 = Convert.ToString(Console.ReadLine());
            String name3 = Convert.ToString(Console.ReadLine());
            String name4 = Convert.ToString(Console.ReadLine());
            String name5 = Convert.ToString(Console.ReadLine());
            String[] arrayList = { name1, name2, name3, name4, name5 };

            


            Console.WriteLine("\nWWrite five names\n" + arrayList[4] + " " + arrayList[3] + " " + arrayList[2] + " " + arrayList[1] + " " + arrayList[0]);
        }
    }
}
            
