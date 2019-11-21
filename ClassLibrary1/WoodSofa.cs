using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class WoodSofa : AbstractSofa
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Деревянный диван готов");
        }
    }
}