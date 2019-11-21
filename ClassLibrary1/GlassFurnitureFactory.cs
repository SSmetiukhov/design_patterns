using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class GlassFurnitureFactory : AbstractFactory
    {
        public override AbstractTable CreateTable()
        {
            return new GlassTable();
        }
        public override AbstractChair CreateChair()
        {
            return new GlassChair();
        }
        public override AbstractSofa CreateSofa()
        {
            return new GlassSofa();
        }
    }

}