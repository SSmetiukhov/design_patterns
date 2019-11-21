using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class PlasticFurnitureFactory : AbstractFactory
    {
        public override AbstractTable CreateTable()
        {
            return new PlasticTable();
        }
        public override AbstractChair CreateChair()
        {
            return new PlasticChair();
        }
        public override AbstractSofa CreateSofa()
        {
            return new PlasticSofa();
        }
    }
}