using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class WoodFurnitureFactory : AbstractFactory
    {
        public override AbstractTable CreateTable()
        {
            return new WoodTable();
        }
        public override AbstractChair CreateChair()
        {
            return new WoodChair();
        }
        public override AbstractSofa CreateSofa()
        {
            return new WoodSofa();
        }
    }
}