﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Palimino : Horse
    {
        public Palimino() : base("Palimino")
        { }

        public override String eat()
        {
            return "nom nom nom" + base.eat(); 
        }
    }
}
