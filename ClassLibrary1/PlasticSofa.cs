using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class PlasticSofa : AbstractSofa
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Пластиковый диван готов");
        }
    }
}