using System;

namespace AreYouBill
    {
    class AreYouBill
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.Write(name+ " is your name huh? ");
      
            switch (name)
            {
                    case "bill":
                    Console.WriteLine("Bill");
                    break;

                    case "alext":
                    Console.WriteLine("Alext");
                    break;
                    case "tom":
                    Console.WriteLine("Tom");
                    break;
                    default:
                    Console.WriteLine("I dont know who you are");
                    break;


            }

            Console.ReadKey();
            

        }
    }
}
