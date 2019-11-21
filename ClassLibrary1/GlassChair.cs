using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class GlassChair : AbstractChair
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Стеклянный стул готов");
        }
    }
}