using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Client
    {
        AbstractFactory factory;
        public Client(AbstractFactory factory)
        {
            this.factory = factory;
        }

        public void MakeOrder()
        {
            AbstractChair chair = factory.CreateChair();
            AbstractSofa sofa = factory.CreateSofa();
            AbstractTable table = factory.CreateTable();
            Console.WriteLine("\n> Информация о заказе:");
            Console.WriteLine("======================================");
            chair.DisplayInfo();
            sofa.DisplayInfo();
            table.DisplayInfo();
            Console.WriteLine("======================================");
        }
    }
}
