﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class WoodTable : AbstractTable
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Деревянный стол готов");
        }
    }
}