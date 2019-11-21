using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class GlassSofa : AbstractSofa
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Стеклянный диван готов");
        }
    }
}