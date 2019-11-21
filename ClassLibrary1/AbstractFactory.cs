using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class AbstractFactory
    {
        public abstract AbstractTable CreateTable();


        public abstract AbstractChair CreateChair();

        public abstract AbstractSofa CreateSofa();
        

    }
}
