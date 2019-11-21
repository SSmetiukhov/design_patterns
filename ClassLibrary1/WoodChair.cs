using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class WoodChair : AbstractChair
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Деревянный стул готов");
        }
    }
}