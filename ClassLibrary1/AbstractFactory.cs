using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AbstractFactory
    {
        public virtual AbstractTable CreateTable()
        {
            return new AbstractTable();
        }

        public virtual AbstractChair CreateChair()
        {
            return new AbstractChair();
        }
        public virtual AbstractSofa CreateSofa()
        {
            return new AbstractSofa();
        }

    }
}
