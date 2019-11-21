using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n\t======================================================");
            Console.WriteLine("\t\t Система управления мебельным магазином ");
            Console.WriteLine("\t======================================================\n");

            Client c1 = new Client(new WoodFurnitureFactory());
            Client c2 = new Client(new PlasticFurnitureFactory());
            Client c3 = new Client(new GlassFurnitureFactory());

            Client[] clients = new Client[3] { c1, c2, c3 };
            foreach (Client c in clients)
            {
                c.MakeOrder();
            }

            Console.WriteLine("\t\t\t Програма завершена");

        }
    }
}
